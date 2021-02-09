using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FormUI.Modules
{
    public class CreateMessage
    {
        public void CreateMessageBox(string JsonResult)
        {
            JArray jsonArray = JArray.Parse(JsonResult);
            string message = "";
            string status = "";
            foreach (JObject item in jsonArray)
            {
                status = (item.GetValue("Status") == null) ? "" : item.GetValue("Status").ToString();
                message += "• "+item.GetValue("ErrorMessage").ToString()+"\n";
            }
            if (status == "success")
                MessageBox.Show(message, message,MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(message,"Bir hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
