using Com.Alipay;
using Com.Alipay.Business;
using Com.Alipay.Domain;
using Com.Alipay.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace CardRecharge
{
    public partial class Form1 : Form
    {
        ServiceReference1.DoorAuthoritySoapClient service = new CardRecharge.ServiceReference1.DoorAuthoritySoapClient();
        IAlipayTradeService serviceClient = F2FBiz.CreateClientInstance(Config.serverUrl, Config.appId, Config.merchant_private_key, Config.version,
                          Config.sign_type, Config.alipay_public_key, Config.charset);
        //private readonly AlipayService _alipayService;
        public Form1(string empid,string empname, string deptname)
        {
            InitializeComponent();
            this.lblRemark.Text = "系统使用说明：\r\n 1.1.确认信息后输入充值金额点击“生成支付码”\r\n 2.扫码支付，等待支付结果显示\r\n 3.如需查询充值记录，点击左上角系统->充值记录查询 \r\n 5.如需修改密码，点击左上角系统->修改密码";
            CheckForIllegalCrossThreadCalls = false;
            this.TbWorkid.Text = empid;
            this.TbEmpName.Text = empname;
            this.TbDeptName.Text = deptname;
        }
        public Form1()
        {
            InitializeComponent();
            this.lblRemark.Text = "系统使用说明：\r\n 1.确认信息后输入充值金额点击“生成支付码”\r\n 2.扫码支付，等待支付结果显示\r\n 3.如需查询充值记录，点击左上角系统->充值记录查询 \r\n 5.如需修改密码，点击左上角系统->修改密码"; 
            CheckForIllegalCrossThreadCalls = false;
        }
        private void QueryUserInfo_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = true;
            this.lblSuccess.Visible = false;
            this.lblCz.Visible = false;
            this.lblBt.Visible = false;

            AlipayTradePrecreateContentBuilder builder = BuildPrecreateContent();
            string out_trade_no = builder.out_trade_no;
            WIDout_request_no.Text = out_trade_no;

            //如果需要接收扫码支付异步通知，那么请把下面两行注释代替本行。
            //推荐使用轮询撤销机制，不推荐使用异步通知,避免单边账问题发生。
            AlipayF2FPrecreateResult precreateResult = serviceClient.tradePrecreate(builder);
            //string notify_url = "http://10.5.21.14/notify_url.aspx";  //商户接收异步通知的地址
            //AlipayF2FPrecreateResult precreateResult = serviceClient.tradePrecreate(builder, notify_url);

            //以下返回结果的处理供参考。
            //payResponse.QrCode即二维码对于的链接
            //将链接用二维码工具生成二维码打印出来，顾客可以用支付宝钱包扫码支付。
            string result = "";

            switch (precreateResult.Status)
            {
                case ResultEnum.SUCCESS:
                    DoWaitProcess(precreateResult);
                    break;
                case ResultEnum.FAILED:
                    result = precreateResult.response.Body;
                    //Response.Redirect("result.aspx?Text=" + result);
                    break;

                case ResultEnum.UNKNOWN:
                    if (precreateResult.response == null)
                    {
                        result = "配置或网络异常，请检查后重试";
                    }
                    else
                    {
                        result = "系统异常，请更新外部订单后重新发起请求";
                    }
                    //Response.Redirect("result.aspx?Text=" + result);
                    break;
            }
        }

        /// <summary>
        /// 生成二维码并展示到页面上
        /// </summary>
        /// <param name="precreateResult">二维码串</param>
        private void DoWaitProcess(AlipayF2FPrecreateResult precreateResult)
        {
            //打印出 preResponse.QrCode 对应的条码
            Bitmap bt;
            string enCodeString = precreateResult.response.QrCode;
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
            qrCodeEncoder.QRCodeScale = 3;
            qrCodeEncoder.QRCodeVersion = 8;
            bt = qrCodeEncoder.Encode(enCodeString, Encoding.UTF8);
            string filename = System.DateTime.Now.ToString("yyyyMMddHHmmss") + "0000" + (new Random()).Next(1, 10000).ToString()
             + ".jpg";
            string path = System.Windows.Forms.Application.StartupPath;
            string folder = System.IO.Path.Combine(path, "images");
            bt.Save(folder + filename);
            this.pictureBox1.Image = Image.FromFile(folder + filename);//"~/images/" + filename;

            //轮询订单结果
            //根据业务需要，选择是否新起线程进行轮询
             ParameterizedThreadStart ParStart = new ParameterizedThreadStart(LoopQuery);
             Thread myThread = new Thread(ParStart);
             object o = precreateResult.response.OutTradeNo;
             myThread.Start(o);

        }


        /// <summary>
        /// 构造支付请求数据
        /// </summary>
        /// <returns>请求数据集</returns>
        private AlipayTradePrecreateContentBuilder BuildPrecreateContent()
        {
            //线上联调时，请输入真实的外部订单号。
            string out_trade_no = "";
            if (String.IsNullOrEmpty(WIDout_request_no.Text.Trim()))
            {
                out_trade_no = System.DateTime.Now.ToString("yyyyMMddHHmmss") + "0000" + (new Random()).Next(1, 10000).ToString();
            }
            else
            {
                out_trade_no = WIDout_request_no.Text.Trim();
            }

            AlipayTradePrecreateContentBuilder builder = new AlipayTradePrecreateContentBuilder();
            //收款账号
            builder.seller_id = Config.pid;
            //订单编号
            builder.out_trade_no = out_trade_no;
            //订单总金额
            builder.total_amount = WIDtotal_fee.Text.Trim();
            //参与优惠计算的金额
            //builder.discountable_amount = "";
            //不参与优惠计算的金额
            //builder.undiscountable_amount = "";
            //订单名称
            builder.subject = WIDsubject.Text.Trim();
            //自定义超时时间
            builder.timeout_express = "5m";
            //订单描述
            builder.body = "";
            //门店编号，很重要的参数，可以用作之后的营销
            builder.store_id = "test store id";
            //操作员编号，很重要的参数，可以用作之后的营销
            builder.operator_id = "test";

            //传入商品信息详情
            List<GoodsInfo> gList = new List<GoodsInfo>();
            GoodsInfo goods = new GoodsInfo();
            goods.goods_id = "goods id";
            goods.goods_name = "goods name";
            goods.price = "0.01";
            goods.quantity = "1";
            gList.Add(goods);
            builder.goods_detail = gList;

            //系统商接入可以填此参数用作返佣
            //ExtendParams exParam = new ExtendParams();
            //exParam.sysServiceProviderId = "20880000000000";
            //builder.extendParams = exParam;

            return builder;

        }
        /// <summary>
        /// 轮询
        /// </summary>
        /// <param name="o">订单号</param>
        public void LoopQuery(object o)
        {
            AlipayF2FQueryResult queryResult = new AlipayF2FQueryResult();
            int count = 100;
            int interval = 10000;
            string out_trade_no = o.ToString();

            for (int i = 1; i <= count; i++)
            {
                Thread.Sleep(interval);
                queryResult = serviceClient.tradeQuery(out_trade_no);
                if (queryResult != null)
                {
                    if (queryResult.Status == ResultEnum.SUCCESS)
                    {
                        DoSuccessProcess(queryResult);
                        return;
                    }
                }
            }
            DoFailedProcess(queryResult);
        }

        /// <summary>
        /// 请添加支付成功后的处理
        /// </summary>
        private void DoSuccessProcess(AlipayF2FQueryResult queryResult)
        {
            //支付成功，请更新相应单据
            //log.WriteLine("扫码支付成功：外部订单号" + queryResult.response.OutTradeNo);
            MessageBox.Show("success");
            //Thread td = new Thread(SetLabel);
            //td.Start();
            SetLabel();
        }

        public void SetLabel()
        {
            this.pictureBox1.Image = null;
            this.lblSuccess.Text = "充值成功";
            this.pictureBox1.Visible = false;
            this.lblSuccess.Visible = true;
            this.lblCz.Visible = true;
            this.lblBt.Visible = true;
            string[] result = service.GetBalance(this.TbWorkid.Text).Split('|');
            this.lblSuccess.Text = "充值成功";
            this.lblBt.Text = "补贴余额：" + result[0] + " 元";
            this.lblCz.Text = "充值余额：" + result[1] + " 元";
        }
        /// <summary>
        /// 请添加支付失败后的处理
        /// </summary>
        private void DoFailedProcess(AlipayF2FQueryResult queryResult)
        {
            //支付失败，请更新相应单据
            MessageBox.Show("Fail");
        }

        

        private void ItemQuery_Click(object sender, EventArgs e)
        {
            Form_QueryRecord queryForm = new Form_QueryRecord();
            queryForm.Show();
        }

        private void ItemChangePwd_Click(object sender, EventArgs e)
        {
            Form_ChangePwd changeForm = new Form_ChangePwd(TbWorkid.Text);
            changeForm.Show();
        }
    }
}
