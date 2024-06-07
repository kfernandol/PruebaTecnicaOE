using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PruebaTecnicaOEInternacional
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Prueba de la clase creada para el manejo de la db
                Database db = new Database("Data Source=localhost,1439;Initial Catalog=Tickend;User ID=sa;Password=Test!2039");
                var rows = db.GetRowCount("SELECT * FROM [User]");
                var data = db.ExecuteQuery("SELECT * FROM [User]");
            }
        }
    }
}