﻿using Run00.SqlCopy;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Run00.SqlCopySqlServer
{
	public class TableBulkCopy : ITableBulkCopy
	{
		void ITableBulkCopy.Copy(IDbConnection connection, DataTable data)
		{
			var sqlConnection = connection as SqlConnection;
			if (sqlConnection == null)
				throw new InvalidOperationException();

			var copy = new SqlBulkCopy(sqlConnection);
			copy.DestinationTableName = data.TableName;
			copy.WriteToServer(data);
		}
	}
}