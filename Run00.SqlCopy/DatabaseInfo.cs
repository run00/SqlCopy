﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Run00.SqlCopy
{
	public class DatabaseInfo
	{
		public string Server { get; private set; }
		public string Database { get; private set; }
		public string ConnectionString { get; private set; }

		public DatabaseInfo(string connectionString)
		{
			Contract.Requires(string.IsNullOrWhiteSpace(connectionString) == false);

			ConnectionString = connectionString;

			var connectionBuilder = new SqlConnectionStringBuilder(connectionString);
			Server = connectionBuilder.DataSource;
			Database = connectionBuilder.InitialCatalog;
		}
	}
}
