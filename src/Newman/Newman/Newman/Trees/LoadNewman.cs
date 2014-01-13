using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Newman.Newman.Model;
using umbraco.businesslogic;
using umbraco.cms.presentation.Trees;
using umbraco.interfaces;

namespace Newman.Trees
{
    [Tree("settings", "newmanTree", "Newman")]
    public class LoadNewman : BaseTree
    {
        public LoadNewman(string application)
            : base(application)
        {
        }

        protected override void CreateRootNode(ref XmlTreeNode rootNode)
        {
            rootNode.Icon = FolderIcon;
            rootNode.OpenIcon = FolderIconOpen;
            rootNode.NodeType = "init" + TreeAlias;
            rootNode.NodeID = "init";
            rootNode.Action = "javascript:openNewmanDashboard()";
        }

        public override void Render(ref XmlTree tree)
        {
            foreach (var email in Data.GetAll())
            {
                var node = XmlTreeNode.Create(this);
                node.NodeID = email.Id.ToString();
                node.NodeType = "email";
                node.Text = email.ToString();
                node.Action = string.Format("javascript:openNewman({0});", email.Id.ToString());
                node.Icon = "../../../App_Plugins/Newman/Icons/example-icon.png";
                node.OpenIcon = "../../../App_Plugins/Newman/Icons/example-icon.png";
                node.HasChildren = false;
                node.Menu = new List<IAction>();
                OnBeforeNodeRender(ref tree, ref node, EventArgs.Empty);
                if (node != null)
                {
                    tree.Add(node);
                    OnAfterNodeRender(ref tree, ref node, EventArgs.Empty);
                }
            }
        }

        public override void RenderJS(ref StringBuilder Javascript)
        {
            Javascript.Append(
               @"function openNewman(id) {
                 UmbClientMgr.contentFrame('../App_Plugins/Newman/Index?id='+id);
                }");

            Javascript.Append(
             @"function openNewmanDashboard() {
                 UmbClientMgr.contentFrame('../App_Plugins/Newman/);
                }");
        }
    }
}