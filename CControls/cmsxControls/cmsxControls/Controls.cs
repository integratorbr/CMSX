using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CmsxControls
{

    public class aiListView : ListView
    {
        int groupDisplayIndex = 1; /*update on June 16, 2010*/
        private ITemplate _alternatingGroupTemplate;
        public virtual ITemplate AlternatingGroupTemplate
        {
            get { return _alternatingGroupTemplate; }
            set { _alternatingGroupTemplate = value; }
        }

        protected override void InstantiateGroupTemplate(System.Web.UI.Control container)
        {

            ITemplate template = this._alternatingGroupTemplate;
            if (_alternatingGroupTemplate != null && GroupItemCount > 0 && groupDisplayIndex % 2 == 0 /*update on June 16, 2010*/)
            {
                template = this._alternatingGroupTemplate;
            }
            else
            {
                template = this.GroupTemplate;
            }

            template.InstantiateIn(container);
            groupDisplayIndex++;
        }
    }
}
