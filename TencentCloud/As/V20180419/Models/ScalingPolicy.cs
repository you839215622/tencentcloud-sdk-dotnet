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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScalingPolicy : AbstractModel
    {
        
        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [JsonProperty("AutoScalingGroupId")]
        public string AutoScalingGroupId{ get; set; }

        /// <summary>
        /// 告警触发策略ID。
        /// </summary>
        [JsonProperty("AutoScalingPolicyId")]
        public string AutoScalingPolicyId{ get; set; }

        /// <summary>
        /// 告警触发策略名称。
        /// </summary>
        [JsonProperty("ScalingPolicyName")]
        public string ScalingPolicyName{ get; set; }

        /// <summary>
        /// 告警触发后，期望实例数修改方式。取值 ：<br><li>CHANGE_IN_CAPACITY：增加或减少若干期望实例数</li><li>EXACT_CAPACITY：调整至指定期望实例数</li> <li>PERCENT_CHANGE_IN_CAPACITY：按百分比调整期望实例数</li>
        /// </summary>
        [JsonProperty("AdjustmentType")]
        public string AdjustmentType{ get; set; }

        /// <summary>
        /// 告警触发后，期望实例数的调整值。
        /// </summary>
        [JsonProperty("AdjustmentValue")]
        public long? AdjustmentValue{ get; set; }

        /// <summary>
        /// 冷却时间。
        /// </summary>
        [JsonProperty("Cooldown")]
        public ulong? Cooldown{ get; set; }

        /// <summary>
        /// 告警监控指标。
        /// </summary>
        [JsonProperty("MetricAlarm")]
        public MetricAlarm MetricAlarm{ get; set; }

        /// <summary>
        /// 通知组ID，即为用户组ID集合。
        /// </summary>
        [JsonProperty("NotificationUserGroupIds")]
        public string[] NotificationUserGroupIds{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupId", this.AutoScalingGroupId);
            this.SetParamSimple(map, prefix + "AutoScalingPolicyId", this.AutoScalingPolicyId);
            this.SetParamSimple(map, prefix + "ScalingPolicyName", this.ScalingPolicyName);
            this.SetParamSimple(map, prefix + "AdjustmentType", this.AdjustmentType);
            this.SetParamSimple(map, prefix + "AdjustmentValue", this.AdjustmentValue);
            this.SetParamSimple(map, prefix + "Cooldown", this.Cooldown);
            this.SetParamObj(map, prefix + "MetricAlarm.", this.MetricAlarm);
            this.SetParamArraySimple(map, prefix + "NotificationUserGroupIds.", this.NotificationUserGroupIds);
        }
    }
}

