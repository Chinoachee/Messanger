using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger.Model.Message
{
    internal class Message
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private int userFrom;

		public int UserFrom
		{
			get { return userFrom; }
			set { userFrom = value; }
		}
		private int userTo;

		public int UserTo
		{
			get { return userTo; }
			set { userTo = value; }
		}
		private string text;

		public string Text
		{
			get { return text; }
			set { text = value; }
		}




	}
}
