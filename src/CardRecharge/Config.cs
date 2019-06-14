using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardRecharge
{
    public class Config
    {
        public static string alipay_public_key = @"MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA0Aw+1jgKhgEpRcxSn5jidyTYrAMJ7MqCXB9YZAiRHwQKw4xXm7fr0Yw1XQdjxZcExZtvBxeiD4z3AvUGuQHqGCQtcj62f6D0isphNT+RJuVXhFJIWn1CrJgEkxul+2xx4yQVthMBl3XwmpmbIEVO5jziy+tlgzr8/KJJXBAWoXYyG+8FImvAtFt785Q2p+RIawmyR9/W6bQ+2jMjpO+q7kVOz64wzTpNSGBquh22SOV8+MJb69SlQvRBY+vobuNCDZrnBTEIAg1IH8WQXNaUYB268x5cqfjOSXDmm9mVSZziPE3vHk0qii75Y28drd4poFtVQ2e/+HAkNf0KK4/XFQIDAQAB";



        //这里要配置没有经过的原始私钥

        //开发者私钥
        public static string merchant_private_key = @"MIIEowIBAAKCAQEAkmuJtxhldSgrIr1kRjLqh6RM5l0weKGjlFeyC9dXf1c/D9O16b+Zi/ueQw6NaX1xDStVbQ7IbEGQS5uERGNtoPNa7peiHHGnlmCK2TYQkWODO8QmNKN2VHQJqvl2Vgu8c+RrSjr7lHAHW20IYbZ1dCVqnaV0iR8Z9tnh1kGeUgFK/85WvhpZ05xuvD39V3SiqQGBHvgCoYKIoZA8lxZlWeKz/y680hzDzp/qbrnDIZk8ZkaisFzkmG46jgyEwxOt900+KTE6PwyhN1l+b1aps6d01hEzSmgkQhVAFBpjg31re1Tdgj2aiaW2gMT+GjFFm3Al7jqyYccjCjxflVrj4wIDAQABAoIBACroe7+d1SGrp1RzZv7RbfxZEDYUCh/X0o2m02T38sq9ARx8wNsizHcCwkLJcXSAD9C5qbufcOmUnxohFXZLIvXfSv8PjbDDN8bwPNBhsSJCJNOvbDjRzFv8c1bY6y5VGyFlR3HF7jL2T5mhzqp/41SpoGBZe9ixNhUqja2RpjlGeFRevjumHDkqHdNAG8q1gk6TX4vrjF84+fM/JjO7rXCzjmkogTDavCu0XRMH2KepT2dZZeWrvC/sJGv+RM2lz3HI+QiGsiVqNdQrCMXH5SwLj99G6BNMCzgMQg2vcZEblcxWdGeozM4faIMJ0skR+A7dDElj63huD/Ewj7UBRjkCgYEA2+b5lNRKYc2S12vt/m/dW+QKQc4myA1wQBrKYrW7VNwrLicQrdgpjU2Tp8se/QbbIOyBsDR7lFn18Q56nPKgZc7Qrv6qU498NoAAypsUAWfQMHOoSoKzpmQ8TLXJoNTfRDPVxd3/m15SSgUw4QGJQb8LYQWAM3FTUSz51qpf64kCgYEAqnSY342N4f/jVeM3y6DhaIgslXDA6NuzGE3Qg/CXzEyEh36Efb1m1uYhvmewgVFBDjzBkJxsIQCLEFU4M1qOUBns18PtN1dZ75Yf33PTZYXZCoKCngMbP6nGqUU5ArWxmIVtvaHrjCnIkYNJBHwau90gFju40ynvfiNkohOTXQsCgYBZaGHVhzLu7PxlJfbP2n+v2tnow361G/Glvr7Gv4j5CcNssmlvpVHPp9j/AfEJg34YttBL6irMuH7skax8n5Fjk2D5pYVvEAm6xvSLa94IbEMTUBL+qIGOh3aU4dymzaYxProOByLj8seWXOHwugUqfBiOTARB5jOv749tHjx9sQKBgBsKploI3fJ1ov40LtzaKAhqWhBXM/N9Lzty1Nqpp5tcpEXOl3xPOOps1fub/Y92cYitsNOdTTYrHOS5cFINUrh4dG+CgLaf3/+3ZFURzf60LkuRiuFAguklqQOfnLzGUGdu+4rzDihNVKlpF4NjoOYe3YFJdjfh1kG/oa5oxp8jAoGBANXOnRw4YIkDf1NYLQNEX9u7wOdfkPh9dbmUS1qPB+W0yYmhEwO8cCRJhYbxj0fEBy6UkpHyMDIZ/jS+i6n6ZAvGkboSMDPEqy594d0OL/ZWicbgARfvuN78DGG/Q6q+RmXTNdnNhWG/Qtz5uAx3wzGDN0G+GuooWjpelJUahPz0";


        //开发者公钥
        public static string merchant_public_key = @"此处填写开发者公钥";

        //应用ID
        public static string appId = "2016092900626296";

        //合作伙伴ID：partnerID
        public static string pid = "2088102177852133";


        //支付宝网关
        public static string serverUrl = "https://openapi.alipaydev.com/gateway.do";
        public static string mapiUrl = "https://mapi.alipaydev.com/gateway.do";
        public static string monitorUrl = "http://mcloudmonitor.com/gateway.do";
        //https://openapi.alipaydev.com/gateway.do

        //编码，无需修改
        public static string charset = "utf-8";
        //签名类型，支持RSA2（推荐！）、RSA
        //public static string sign_type = "RSA2";
        public static string sign_type = "RSA2";
        //版本号，无需修改
        public static string version = "1.0";


        /// <summary>
        /// 公钥文件类型转换成纯文本类型
        /// </summary>
        /// <returns>过滤后的字符串类型公钥</returns>
        public static string getMerchantPublicKeyStr()
        {
            StreamReader sr = new StreamReader(merchant_public_key);
            string pubkey = sr.ReadToEnd();
            sr.Close();
            if (pubkey != null)
            {
                pubkey = pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("\r", "");
                pubkey = pubkey.Replace("\n", "");
            }
            return pubkey;
        }

        /// <summary>
        /// 私钥文件类型转换成纯文本类型
        /// </summary>
        /// <returns>过滤后的字符串类型私钥</returns>
        public static string getMerchantPriveteKeyStr()
        {
            StreamReader sr = new StreamReader(merchant_private_key);
            string pubkey = sr.ReadToEnd();
            sr.Close();
            if (pubkey != null)
            {
                pubkey = pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("\r", "");
                pubkey = pubkey.Replace("\n", "");
            }
            return pubkey;
        }

    }
}
