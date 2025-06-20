using System;
using NetFwTypeLib;
using System.Windows.Forms;

namespace Destiny2_SoloLobby
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Code for the Buttons
        private void btnSolo_Click(object sender, EventArgs e)
        {
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            #region Rule existence check
            // Check if firewall policies already exist
            foreach (INetFwRule rule in firewallPolicy.Rules)
            {
                if (rule.Name.IndexOf("Destiny2-In") != -1 || rule.Name.IndexOf("Destiny2-Out") != -1)
                {
                    return;
                }
            }
            #endregion

            #region Inbound Port Rules
            // Inbound remote ports block
            INetFwRule firewallRuleInTcp = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            firewallRuleInTcp.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            firewallRuleInTcp.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            firewallRuleInTcp.Enabled = true;
            firewallRuleInTcp.InterfaceTypes = "All";
            firewallRuleInTcp.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
            firewallRuleInTcp.RemotePorts = "27000-29000,3097";
            firewallRuleInTcp.Name = "Destiny2-In-TCP";

            INetFwRule firewallRuleInUdp = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            firewallRuleInUdp.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            firewallRuleInUdp.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_IN;
            firewallRuleInUdp.Enabled = true;
            firewallRuleInUdp.InterfaceTypes = "All";
            firewallRuleInUdp.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            firewallRuleInUdp.RemotePorts = "27000-29000,3097";
            firewallRuleInUdp.Name = "Destiny2-In-UDP";
            #endregion

            #region Outbound Port Rules
            // Outbound remote ports block
            INetFwRule firewallRuleOutTcp = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            firewallRuleOutTcp.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            firewallRuleOutTcp.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            firewallRuleOutTcp.Enabled = true;
            firewallRuleOutTcp.InterfaceTypes = "All";
            firewallRuleOutTcp.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_TCP;
            firewallRuleOutTcp.RemotePorts = "27000-29000,3097";
            firewallRuleOutTcp.Name = "Destiny2-Out-TCP";

            INetFwRule firewallRuleOutUdp = (INetFwRule)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FWRule"));
            firewallRuleOutUdp.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
            firewallRuleOutUdp.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
            firewallRuleOutUdp.Enabled = true;
            firewallRuleOutUdp.InterfaceTypes = "All";
            firewallRuleOutUdp.Protocol = (int)NET_FW_IP_PROTOCOL_.NET_FW_IP_PROTOCOL_UDP;
            firewallRuleOutUdp.RemotePorts = "27000-29000,3097";
            firewallRuleOutUdp.Name = "Destiny2-Out-UDP";
            #endregion

            #region Addition of rules to firewall
            // Add the rules to the firewall policies
            firewallPolicy.Rules.Add(firewallRuleInTcp);
            firewallPolicy.Rules.Add(firewallRuleInUdp);
            firewallPolicy.Rules.Add(firewallRuleOutTcp);
            firewallPolicy.Rules.Add(firewallRuleOutUdp);
            #endregion
        }

        private void btnPublic_Click(object sender, EventArgs e)
        {
            INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));

            #region Rule existence check
            // Check if firewall policies already exist
            foreach (INetFwRule rule in firewallPolicy.Rules)
            {
                #region Delete rules if exist
                // Delete if exists
                if (rule.Name.IndexOf("Destiny2-In") != -1 || rule.Name.IndexOf("Destiny2-Out") != -1)
                {
                    INetFwPolicy2 temp = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                    temp.Rules.Remove(rule.Name);
                }
                #endregion
            }
            #endregion
        }
        #endregion
    }
}
