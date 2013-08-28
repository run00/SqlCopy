// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

using System.Diagnostics.CodeAnalysis;

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA2210:AssembliesShouldHaveValidStrongNames",
	Justification = "This assembly is designed to be added at runtime. Signing can cause problems in this instance")]
[assembly: SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes", Scope = "member", 
	Target = "Run00.SqlCopy.BaseEntityQueryFilter`1.#Run00.SqlCopy.IEntityQueryFilter.EntityType",
	Justification = "This method should not be publically available")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", 
	Target = "Run00.SqlCopy.BaseEntityQueryFilter`1.#Run00.SqlCopy.IEntityQueryFilter.Filter(System.Linq.IQueryable,Run00.SqlCopy.IDbRepository)",
	Justification = "The variable 'query' is validated by code contracts")]
