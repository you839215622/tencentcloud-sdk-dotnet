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

namespace TencentCloud.Tag.V20180813
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tag.V20180813.Models;

   public class TagClient : AbstractClient{

       private const string endpoint = "tag.tencentcloudapi.com";
       private const string version = "2018-08-13";

        /// <summary>
        /// 构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region"> 产品地域</param>
        public TagClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        ///  构造client
        /// </summary>
        /// <param name="credential">认证信息实例</param>
        /// <param name="region">产品地域</param>
        /// <param name="profile">配置实例</param>
        public TagClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口用于给标签关联资源
        /// </summary>
        /// <param name="req">参考<see cref="AddResourceTagRequest"/></param>
        /// <returns>参考<see cref="AddResourceTagResponse"/>实例</returns>
        public async Task<AddResourceTagResponse> AddResourceTag(AddResourceTagRequest req)
        {
             JsonResponseModel<AddResourceTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddResourceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddResourceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于创建一对标签键和标签值
        /// </summary>
        /// <param name="req">参考<see cref="CreateTagRequest"/></param>
        /// <returns>参考<see cref="CreateTagResponse"/>实例</returns>
        public async Task<CreateTagResponse> CreateTag(CreateTagRequest req)
        {
             JsonResponseModel<CreateTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于解除标签和资源的关联关系
        /// </summary>
        /// <param name="req">参考<see cref="DeleteResourceTagRequest"/></param>
        /// <returns>参考<see cref="DeleteResourceTagResponse"/>实例</returns>
        public async Task<DeleteResourceTagResponse> DeleteResourceTag(DeleteResourceTagRequest req)
        {
             JsonResponseModel<DeleteResourceTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteResourceTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteResourceTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于删除一对标签键和标签值
        /// </summary>
        /// <param name="req">参考<see cref="DeleteTagRequest"/></param>
        /// <returns>参考<see cref="DeleteTagResponse"/>实例</returns>
        public async Task<DeleteTagResponse> DeleteTag(DeleteTagRequest req)
        {
             JsonResponseModel<DeleteTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已有资源标签键值对
        /// </summary>
        /// <param name="req">参考<see cref="DescribeResourceTagsByResourceIdsRequest"/></param>
        /// <returns>参考<see cref="DescribeResourceTagsByResourceIdsResponse"/>实例</returns>
        public async Task<DescribeResourceTagsByResourceIdsResponse> DescribeResourceTagsByResourceIds(DescribeResourceTagsByResourceIdsRequest req)
        {
             JsonResponseModel<DescribeResourceTagsByResourceIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceTagsByResourceIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceTagsByResourceIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过标签查询资源列表
        /// </summary>
        /// <param name="req">参考<see cref="DescribeResourcesByTagsRequest"/></param>
        /// <returns>参考<see cref="DescribeResourcesByTagsResponse"/>实例</returns>
        public async Task<DescribeResourcesByTagsResponse> DescribeResourcesByTags(DescribeResourcesByTagsRequest req)
        {
             JsonResponseModel<DescribeResourcesByTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourcesByTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesByTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签键。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTagKeysRequest"/></param>
        /// <returns>参考<see cref="DescribeTagKeysResponse"/>实例</returns>
        public async Task<DescribeTagKeysResponse> DescribeTagKeys(DescribeTagKeysRequest req)
        {
             JsonResponseModel<DescribeTagKeysResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagKeys");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagKeysResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表中的标签值。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTagValuesRequest"/></param>
        /// <returns>参考<see cref="DescribeTagValuesResponse"/>实例</returns>
        public async Task<DescribeTagValuesResponse> DescribeTagValues(DescribeTagValuesRequest req)
        {
             JsonResponseModel<DescribeTagValuesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTagValues");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagValuesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于查询已建立的标签列表。
        /// </summary>
        /// <param name="req">参考<see cref="DescribeTagsRequest"/></param>
        /// <returns>参考<see cref="DescribeTagsResponse"/>实例</returns>
        public async Task<DescribeTagsResponse> DescribeTags(DescribeTagsRequest req)
        {
             JsonResponseModel<DescribeTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改资源关联的所有标签
        /// </summary>
        /// <param name="req">参考<see cref="ModifyResourceTagsRequest"/></param>
        /// <returns>参考<see cref="ModifyResourceTagsResponse"/>实例</returns>
        public async Task<ModifyResourceTagsResponse> ModifyResourceTags(ModifyResourceTagsRequest req)
        {
             JsonResponseModel<ModifyResourceTagsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyResourceTags");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyResourceTagsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于修改资源已关联的标签值（标签键不变）
        /// </summary>
        /// <param name="req">参考<see cref="UpdateResourceTagValueRequest"/></param>
        /// <returns>参考<see cref="UpdateResourceTagValueResponse"/>实例</returns>
        public async Task<UpdateResourceTagValueResponse> UpdateResourceTagValue(UpdateResourceTagValueRequest req)
        {
             JsonResponseModel<UpdateResourceTagValueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateResourceTagValue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateResourceTagValueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
