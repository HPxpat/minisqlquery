﻿using System;
using System.Collections.Generic;
using System.Text;
using MiniSqlQuery.Core.Commands;
using System.Windows.Forms;
using MiniSqlQuery.Core;

namespace MiniSqlQuery.PlugIns.ViewTable.Commands
{
	public class ViewTableFromInspectorCommand
		: CommandBase
	{
		public ViewTableFromInspectorCommand()
			: base("&View table data")
		{
			SmallImage = ImageResource.table_go;
		}

		public override void Execute()
		{
			string tableName = Services.HostWindow.DatabaseInspector.RightClickedTableName;
			if (tableName != null)
			{
				ViewTableForm frm = new ViewTableForm(Services, tableName);
				frm.Text = tableName;
				Services.HostWindow.DisplayDockedForm(frm);
			}
		}
	}
}