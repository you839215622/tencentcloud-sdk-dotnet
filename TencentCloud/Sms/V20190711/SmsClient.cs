/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Sms.V20190711
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sms.V20190711.Models;

   public class SmsClient : AbstractClient{

       private const string endpoint = "sms.tencentcloudapi.com";
       private const string version = "2019-07-11";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public SmsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public SmsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 统计用户回执的数据
        /// </summary>
        /// <param name="req">参考<see cref="CallbackStatusStatisticsRequest"/></param>
        /// <returns>参考<see cref="CallbackStatusStatisticsResponse"/>实例</returns>
        public async Task<CallbackStatusStatisticsResponse> CallbackStatusStatistics(CallbackStatusStatisticsRequest req)
        {
             JsonResponseModel<CallbackStatusStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CallbackStatusStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CallbackStatusStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取短信回复状态
        /// </summary>
        /// <param name="req">参考<see cref="PullSmsReplyStatusRequest"/></param>
        /// <returns>参考<see cref="PullSmsReplyStatusResponse"/>实例</returns>
        public async Task<PullSmsReplyStatusResponse> PullSmsReplyStatus(PullSmsReplyStatusRequest req)
        {
             JsonResponseModel<PullSmsReplyStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsReplyStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsReplyStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取单个号码短信回复状态
        /// </summary>
        /// <param name="req">参考<see cref="PullSmsReplyStatusByPhoneNumberRequest"/></param>
        /// <returns>参考<see cref="PullSmsReplyStatusByPhoneNumberResponse"/>实例</returns>
        public async Task<PullSmsReplyStatusByPhoneNumberResponse> PullSmsReplyStatusByPhoneNumber(PullSmsReplyStatusByPhoneNumberRequest req)
        {
             JsonResponseModel<PullSmsReplyStatusByPhoneNumberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsReplyStatusByPhoneNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsReplyStatusByPhoneNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取短信下发状态
        /// </summary>
        /// <param name="req">参考<see cref="PullSmsSendStatusRequest"/></param>
        /// <returns>参考<see cref="PullSmsSendStatusResponse"/>实例</returns>
        public async Task<PullSmsSendStatusResponse> PullSmsSendStatus(PullSmsSendStatusRequest req)
        {
             JsonResponseModel<PullSmsSendStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsSendStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsSendStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取单个号码短信下发状态
        /// </summary>
        /// <param name="req">参考<see cref="PullSmsSendStatusByPhoneNumberRequest"/></param>
        /// <returns>参考<see cref="PullSmsSendStatusByPhoneNumberResponse"/>实例</returns>
        public async Task<PullSmsSendStatusByPhoneNumberResponse> PullSmsSendStatusByPhoneNumber(PullSmsSendStatusByPhoneNumberRequest req)
        {
             JsonResponseModel<PullSmsSendStatusByPhoneNumberResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PullSmsSendStatusByPhoneNumber");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PullSmsSendStatusByPhoneNumberResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 短信发送接口，用户给用户发短信验证码、通知类短信或营销短信。
        /// 
        /// </summary>
        /// <param name="req">参考<see cref="SendSmsRequest"/></param>
        /// <returns>参考<see cref="SendSmsResponse"/>实例</returns>
        public async Task<SendSmsResponse> SendSms(SendSmsRequest req)
        {
             JsonResponseModel<SendSmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 统计用户发送短信的数据
        /// </summary>
        /// <param name="req">参考<see cref="SendStatusStatisticsRequest"/></param>
        /// <returns>参考<see cref="SendStatusStatisticsResponse"/>实例</returns>
        public async Task<SendStatusStatisticsResponse> SendStatusStatistics(SendStatusStatisticsRequest req)
        {
             JsonResponseModel<SendStatusStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendStatusStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendStatusStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户套餐包信息统计
        /// </summary>
        /// <param name="req">参考<see cref="SmsPackagesStatisticsRequest"/></param>
        /// <returns>参考<see cref="SmsPackagesStatisticsResponse"/>实例</returns>
        public async Task<SmsPackagesStatisticsResponse> SmsPackagesStatistics(SmsPackagesStatisticsRequest req)
        {
             JsonResponseModel<SmsPackagesStatisticsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SmsPackagesStatistics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SmsPackagesStatisticsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
