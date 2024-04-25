using NetFwTypeLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlGuru.Base
{
    public class FireWallHelper
    {
        public static void AddOrUpdateInboundRule(string name, int port)
        {
            // 获取防火墙策略对象  
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            // 检查规则是否存在  
            INetFwRule existingRule = firewallPolicy.Rules.Item(name);
            if (existingRule != null)
            {
                // 更新现有规则  
                existingRule.LocalPorts = port.ToString();
                // 你可以根据需要更新其他属性，比如 Action, Enabled 等  
               
            }
            else
            {
                // 创建新规则  
                INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwRule"));

                // 设置规则属性  
                firewallRule.Name = name;
                firewallRule.Description = "Allow inbound traffic to my service on port " + port;
                firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
                firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
                firewallRule.Enabled = true;
                firewallRule.Profiles = (int)(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_ALL);
                firewallRule.LocalPorts = port.ToString();
                firewallRule.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
                firewallRule.Grouping = "@firewallapi.dll,-28752"; // 可以自定义分组，或者留空  
                firewallRule.EdgeTraversal = false; 

                // 添加新规则到防火墙策略  
                firewallPolicy.Rules.Add(firewallRule);
               
            }
        }

    }
}
