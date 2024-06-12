using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MultiSelectTreeView : TreeView
    {
        private List<TreeNode> selectedNodes;

        public MultiSelectTreeView()
        {
            selectedNodes = new List<TreeNode>();
        }

        public List<TreeNode> SelectedNodes
        {
            get { return selectedNodes; }
        }

        protected override void OnNodeMouseClick(TreeNodeMouseClickEventArgs e)
        {
            base.OnNodeMouseClick(e);

            if ((ModifierKeys & Keys.Control) == Keys.Control)
            {
                if (selectedNodes.Contains(e.Node))
                {
                    selectedNodes.Remove(e.Node);
                    e.Node.BackColor = SystemColors.Window;
                    e.Node.ForeColor = SystemColors.ControlText; 
                    e.Node.TreeView.Invalidate(e.Node.Bounds);
                    this.Refresh();
                }
                else
                {
                    selectedNodes.Add(e.Node);
                    e.Node.BackColor = SystemColors.Highlight;
                    e.Node.ForeColor = SystemColors.HighlightText;
                }
            }
            else
            {
                ClearSelectedNodes();
                if (!selectedNodes.Contains(e.Node))
                {
                    selectedNodes.Add(e.Node);
                    e.Node.BackColor = SystemColors.Highlight;
                    e.Node.ForeColor = SystemColors.HighlightText;
                }
                else
                {
                    selectedNodes.Remove(e.Node);
                    e.Node.BackColor = this.BackColor;
                    e.Node.ForeColor = this.ForeColor;
                }
            }
        }

        public void ClearSelectedNodes()
        {
            foreach (TreeNode node in selectedNodes)
            {
                node.BackColor = this.BackColor;
                node.ForeColor = this.ForeColor;
            }
            selectedNodes.Clear();
        }

        public List<TreeNode> GetSelectedNodes()
        {
            return selectedNodes;
        }

    }
}
