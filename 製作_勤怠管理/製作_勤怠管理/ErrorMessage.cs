using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 製作_勤怠管理
{
    
    /// <summary>
    /// エラーメッセージ
    /// </summary>
    class ErrorMessage
    {
        /// <summary>
        /// ログインに失敗した時に表示されるエラーメッセージ
        /// </summary>
        public void LoginError()
        {
            MessageBox.Show("正しい値を入力してください。","エラー",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
