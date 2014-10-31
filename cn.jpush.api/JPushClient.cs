﻿using cn.jpush.api.common;
using cn.jpush.api.push;
using cn.jpush.api.push.mode;
using cn.jpush.api.report;
using cn.jpush.api.util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cn.jpush.api
{
    /// <summary>
    /// Main Entrance - 该类为JPush服务的主要入口
    /// </summary>
    public class JPushClient
    {
        private PushClient _pushClient;
        private ReportClient _reportClient;
        /// <summary>
        /// 带两个参数的构造函数，该状态下，ApnsProduction默认为true
        /// </summary>
        /// <param name="app_key">Portal上产生的app_key</param>
        /// <param name="masterSecret">你的API MasterSecret</param>
        public JPushClient(String app_key, String masterSecret)
        {
            _pushClient = new PushClient(masterSecret, app_key);
            _reportClient = new ReportClient(app_key, masterSecret);

        }
        public void SendPush(PushPayload payload){
            _pushClient.sendPush(payload);
        }
        public ReceivedResult getReceivedApi(String msg_ids)
        {
            return _reportClient.getReceiveds(msg_ids);
        }
        static void Main(String[] args) 
        {
            Console.WriteLine("2222");
        }
    }
}