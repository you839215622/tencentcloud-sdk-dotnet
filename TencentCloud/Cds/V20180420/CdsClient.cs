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

namespace TencentCloud.Cds.V20180420
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Cds.V20180420.Models;

   public class CdsClient : AbstractClient{

       private const string endpoint = "cds.tencentcloudapi.com";
       private const string version = "2018-04-20";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public CdsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public CdsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口 (DescribeDbauditInstanceType) 用于查询可售卖的产品规格列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDbauditInstanceTypeRequest"/></param>
        /// <returns>参考<see cref="DescribeDbauditInstanceTypeResponse"/>实例</returns>
        public async Task<DescribeDbauditInstanceTypeResponse> DescribeDbauditInstanceType(DescribeDbauditInstanceTypeRequest req)
        {
             JsonResponseModel<DescribeDbauditInstanceTypeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDbauditInstanceType");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbauditInstanceTypeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeDbauditInstances) 用于查询数据安全审计实例列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDbauditInstancesRequest"/></param>
        /// <returns>参考<see cref="DescribeDbauditInstancesResponse"/>实例</returns>
        public async Task<DescribeDbauditInstancesResponse> DescribeDbauditInstances(DescribeDbauditInstancesRequest req)
        {
             JsonResponseModel<DescribeDbauditInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDbauditInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbauditInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeDbauditUsedRegions) 用于查询可售卖地域列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeDbauditUsedRegionsRequest"/></param>
        /// <returns>参考<see cref="DescribeDbauditUsedRegionsResponse"/>实例</returns>
        public async Task<DescribeDbauditUsedRegionsResponse> DescribeDbauditUsedRegions(DescribeDbauditUsedRegionsRequest req)
        {
             JsonResponseModel<DescribeDbauditUsedRegionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDbauditUsedRegions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDbauditUsedRegionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询数据安全审计产品实例价格
        /// </summary>
        /// <param name="req">参考<see cref="InquiryPriceDbauditInstanceRequest"/></param>
        /// <returns>参考<see cref="InquiryPriceDbauditInstanceResponse"/>实例</returns>
        public async Task<InquiryPriceDbauditInstanceResponse> InquiryPriceDbauditInstance(InquiryPriceDbauditInstanceRequest req)
        {
             JsonResponseModel<InquiryPriceDbauditInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "InquiryPriceDbauditInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<InquiryPriceDbauditInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (ModifyDbauditInstancesRenewFlag) 用于修改数据安全审计产品实例续费标识
        /// </summary>
        /// <param name="req">参考<see cref="ModifyDbauditInstancesRenewFlagRequest"/></param>
        /// <returns>参考<see cref="ModifyDbauditInstancesRenewFlagResponse"/>实例</returns>
        public async Task<ModifyDbauditInstancesRenewFlagResponse> ModifyDbauditInstancesRenewFlag(ModifyDbauditInstancesRenewFlagRequest req)
        {
             JsonResponseModel<ModifyDbauditInstancesRenewFlagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDbauditInstancesRenewFlag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDbauditInstancesRenewFlagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
