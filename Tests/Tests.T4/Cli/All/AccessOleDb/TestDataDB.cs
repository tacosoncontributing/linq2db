// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB;
using LinqToDB.Data;
using LinqToDB.Mapping;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

#pragma warning disable 1573, 1591
#nullable enable

namespace Cli.All.Access.OleDb
{
	public partial class TestDataDB : DataConnection
	{
		public TestDataDB()
		{
			InitDataContext();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
		}

		public TestDataDB(DataOptions options)
			: base(options)
		{
			InitDataContext();
		}

		public TestDataDB(DataOptions<TestDataDB> options)
			: base(options.Options)
		{
			InitDataContext();
		}

		partial void InitDataContext();

		public ITable<AllType>             AllTypes             => this.GetTable<AllType>();
		public ITable<Child>               Children             => this.GetTable<Child>();
		public ITable<DataTypeTest>        DataTypeTests        => this.GetTable<DataTypeTest>();
		public ITable<Doctor>              Doctors              => this.GetTable<Doctor>();
		public ITable<Dual>                Duals                => this.GetTable<Dual>();
		public ITable<GrandChild>          GrandChildren        => this.GetTable<GrandChild>();
		public ITable<InheritanceChild>    InheritanceChildren  => this.GetTable<InheritanceChild>();
		public ITable<InheritanceParent>   InheritanceParents   => this.GetTable<InheritanceParent>();
		public ITable<LinqDataType>        LinqDataTypes        => this.GetTable<LinqDataType>();
		public ITable<Parent>              Parents              => this.GetTable<Parent>();
		public ITable<Patient>             Patients             => this.GetTable<Patient>();
		public ITable<Person>              People               => this.GetTable<Person>();
		public ITable<TestIdentity>        TestIdentities       => this.GetTable<TestIdentity>();
		public ITable<TestMerge1>          TestMerge1           => this.GetTable<TestMerge1>();
		public ITable<TestMerge2>          TestMerge2           => this.GetTable<TestMerge2>();
		public ITable<LinqDataTypesQuery>  LinqDataTypesQueries => this.GetTable<LinqDataTypesQuery>();
		public ITable<LinqDataTypesQuery1> LinqDataTypesQuery1  => this.GetTable<LinqDataTypesQuery1>();
		public ITable<LinqDataTypesQuery2> LinqDataTypesQuery2  => this.GetTable<LinqDataTypesQuery2>();
		public ITable<PatientSelectAll>    PatientSelectAll     => this.GetTable<PatientSelectAll>();
		public ITable<PersonSelectAll>     PersonSelectAll      => this.GetTable<PersonSelectAll>();
		public ITable<ScalarDataReader>    ScalarDataReaders    => this.GetTable<ScalarDataReader>();
	}

	public static partial class ExtensionMethods
	{
		#region Table Extensions
		public static DataTypeTest? Find(this ITable<DataTypeTest> table, int dataTypeId)
		{
			return table.FirstOrDefault(e => e.DataTypeId == dataTypeId);
		}

		public static Task<DataTypeTest?> FindAsync(this ITable<DataTypeTest> table, int dataTypeId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.DataTypeId == dataTypeId, cancellationToken);
		}

		public static IQueryable<DataTypeTest> FindQuery(this ITable<DataTypeTest> table, int dataTypeId)
		{
			return table.Where(e => e.DataTypeId == dataTypeId);
		}

		public static DataTypeTest? Find(this ITable<DataTypeTest> table, DataTypeTest @record)
		{
			return table.FirstOrDefault(e => e.DataTypeId == @record.DataTypeId);
		}

		public static Task<DataTypeTest?> FindAsync(this ITable<DataTypeTest> table, DataTypeTest @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.DataTypeId == @record.DataTypeId, cancellationToken);
		}

		public static IQueryable<DataTypeTest> FindQuery(this ITable<DataTypeTest> table, DataTypeTest @record)
		{
			return table.Where(e => e.DataTypeId == @record.DataTypeId);
		}

		public static DataTypeTest? FindDataTypeTest(this TestDataDB db, int dataTypeId)
		{
			return db.GetTable<DataTypeTest>().FirstOrDefault(e => e.DataTypeId == dataTypeId);
		}

		public static Task<DataTypeTest?> FindDataTypeTestAsync(this TestDataDB db, int dataTypeId, CancellationToken cancellationToken = default)
		{
			return db.GetTable<DataTypeTest>().FirstOrDefaultAsync(e => e.DataTypeId == dataTypeId, cancellationToken);
		}

		public static IQueryable<DataTypeTest> FindDataTypeTestQuery(this TestDataDB db, int dataTypeId)
		{
			return db.GetTable<DataTypeTest>().Where(e => e.DataTypeId == dataTypeId);
		}

		public static DataTypeTest? Find(this TestDataDB db, DataTypeTest @record)
		{
			return db.GetTable<DataTypeTest>().FirstOrDefault(e => e.DataTypeId == @record.DataTypeId);
		}

		public static Task<DataTypeTest?> FindAsync(this TestDataDB db, DataTypeTest @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<DataTypeTest>().FirstOrDefaultAsync(e => e.DataTypeId == @record.DataTypeId, cancellationToken);
		}

		public static IQueryable<DataTypeTest> FindQuery(this TestDataDB db, DataTypeTest @record)
		{
			return db.GetTable<DataTypeTest>().Where(e => e.DataTypeId == @record.DataTypeId);
		}

		public static Doctor? Find(this ITable<Doctor> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Doctor?> FindAsync(this ITable<Doctor> table, int personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Doctor> FindQuery(this ITable<Doctor> table, int personId)
		{
			return table.Where(e => e.PersonId == personId);
		}

		public static Doctor? Find(this ITable<Doctor> table, Doctor @record)
		{
			return table.FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Doctor?> FindAsync(this ITable<Doctor> table, Doctor @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Doctor> FindQuery(this ITable<Doctor> table, Doctor @record)
		{
			return table.Where(e => e.PersonId == @record.PersonId);
		}

		public static Doctor? FindDoctor(this TestDataDB db, int personId)
		{
			return db.GetTable<Doctor>().FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Doctor?> FindDoctorAsync(this TestDataDB db, int personId, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Doctor>().FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Doctor> FindDoctorQuery(this TestDataDB db, int personId)
		{
			return db.GetTable<Doctor>().Where(e => e.PersonId == personId);
		}

		public static Doctor? Find(this TestDataDB db, Doctor @record)
		{
			return db.GetTable<Doctor>().FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Doctor?> FindAsync(this TestDataDB db, Doctor @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Doctor>().FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Doctor> FindQuery(this TestDataDB db, Doctor @record)
		{
			return db.GetTable<Doctor>().Where(e => e.PersonId == @record.PersonId);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, int inheritanceChildId)
		{
			return table.FirstOrDefault(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static Task<InheritanceChild?> FindAsync(this ITable<InheritanceChild> table, int inheritanceChildId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.InheritanceChildId == inheritanceChildId, cancellationToken);
		}

		public static IQueryable<InheritanceChild> FindQuery(this ITable<InheritanceChild> table, int inheritanceChildId)
		{
			return table.Where(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static InheritanceChild? Find(this ITable<InheritanceChild> table, InheritanceChild @record)
		{
			return table.FirstOrDefault(e => e.InheritanceChildId == @record.InheritanceChildId);
		}

		public static Task<InheritanceChild?> FindAsync(this ITable<InheritanceChild> table, InheritanceChild @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.InheritanceChildId == @record.InheritanceChildId, cancellationToken);
		}

		public static IQueryable<InheritanceChild> FindQuery(this ITable<InheritanceChild> table, InheritanceChild @record)
		{
			return table.Where(e => e.InheritanceChildId == @record.InheritanceChildId);
		}

		public static InheritanceChild? FindInheritanceChild(this TestDataDB db, int inheritanceChildId)
		{
			return db.GetTable<InheritanceChild>().FirstOrDefault(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static Task<InheritanceChild?> FindInheritanceChildAsync(this TestDataDB db, int inheritanceChildId, CancellationToken cancellationToken = default)
		{
			return db.GetTable<InheritanceChild>().FirstOrDefaultAsync(e => e.InheritanceChildId == inheritanceChildId, cancellationToken);
		}

		public static IQueryable<InheritanceChild> FindInheritanceChildQuery(this TestDataDB db, int inheritanceChildId)
		{
			return db.GetTable<InheritanceChild>().Where(e => e.InheritanceChildId == inheritanceChildId);
		}

		public static InheritanceChild? Find(this TestDataDB db, InheritanceChild @record)
		{
			return db.GetTable<InheritanceChild>().FirstOrDefault(e => e.InheritanceChildId == @record.InheritanceChildId);
		}

		public static Task<InheritanceChild?> FindAsync(this TestDataDB db, InheritanceChild @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<InheritanceChild>().FirstOrDefaultAsync(e => e.InheritanceChildId == @record.InheritanceChildId, cancellationToken);
		}

		public static IQueryable<InheritanceChild> FindQuery(this TestDataDB db, InheritanceChild @record)
		{
			return db.GetTable<InheritanceChild>().Where(e => e.InheritanceChildId == @record.InheritanceChildId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, int inheritanceParentId)
		{
			return table.FirstOrDefault(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static Task<InheritanceParent?> FindAsync(this ITable<InheritanceParent> table, int inheritanceParentId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.InheritanceParentId == inheritanceParentId, cancellationToken);
		}

		public static IQueryable<InheritanceParent> FindQuery(this ITable<InheritanceParent> table, int inheritanceParentId)
		{
			return table.Where(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static InheritanceParent? Find(this ITable<InheritanceParent> table, InheritanceParent @record)
		{
			return table.FirstOrDefault(e => e.InheritanceParentId == @record.InheritanceParentId);
		}

		public static Task<InheritanceParent?> FindAsync(this ITable<InheritanceParent> table, InheritanceParent @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.InheritanceParentId == @record.InheritanceParentId, cancellationToken);
		}

		public static IQueryable<InheritanceParent> FindQuery(this ITable<InheritanceParent> table, InheritanceParent @record)
		{
			return table.Where(e => e.InheritanceParentId == @record.InheritanceParentId);
		}

		public static InheritanceParent? FindInheritanceParent(this TestDataDB db, int inheritanceParentId)
		{
			return db.GetTable<InheritanceParent>().FirstOrDefault(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static Task<InheritanceParent?> FindInheritanceParentAsync(this TestDataDB db, int inheritanceParentId, CancellationToken cancellationToken = default)
		{
			return db.GetTable<InheritanceParent>().FirstOrDefaultAsync(e => e.InheritanceParentId == inheritanceParentId, cancellationToken);
		}

		public static IQueryable<InheritanceParent> FindInheritanceParentQuery(this TestDataDB db, int inheritanceParentId)
		{
			return db.GetTable<InheritanceParent>().Where(e => e.InheritanceParentId == inheritanceParentId);
		}

		public static InheritanceParent? Find(this TestDataDB db, InheritanceParent @record)
		{
			return db.GetTable<InheritanceParent>().FirstOrDefault(e => e.InheritanceParentId == @record.InheritanceParentId);
		}

		public static Task<InheritanceParent?> FindAsync(this TestDataDB db, InheritanceParent @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<InheritanceParent>().FirstOrDefaultAsync(e => e.InheritanceParentId == @record.InheritanceParentId, cancellationToken);
		}

		public static IQueryable<InheritanceParent> FindQuery(this TestDataDB db, InheritanceParent @record)
		{
			return db.GetTable<InheritanceParent>().Where(e => e.InheritanceParentId == @record.InheritanceParentId);
		}

		public static Patient? Find(this ITable<Patient> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Patient?> FindAsync(this ITable<Patient> table, int personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Patient> FindQuery(this ITable<Patient> table, int personId)
		{
			return table.Where(e => e.PersonId == personId);
		}

		public static Patient? Find(this ITable<Patient> table, Patient @record)
		{
			return table.FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Patient?> FindAsync(this ITable<Patient> table, Patient @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Patient> FindQuery(this ITable<Patient> table, Patient @record)
		{
			return table.Where(e => e.PersonId == @record.PersonId);
		}

		public static Patient? FindPatient(this TestDataDB db, int personId)
		{
			return db.GetTable<Patient>().FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Patient?> FindPatientAsync(this TestDataDB db, int personId, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Patient>().FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Patient> FindPatientQuery(this TestDataDB db, int personId)
		{
			return db.GetTable<Patient>().Where(e => e.PersonId == personId);
		}

		public static Patient? Find(this TestDataDB db, Patient @record)
		{
			return db.GetTable<Patient>().FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Patient?> FindAsync(this TestDataDB db, Patient @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Patient>().FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Patient> FindQuery(this TestDataDB db, Patient @record)
		{
			return db.GetTable<Patient>().Where(e => e.PersonId == @record.PersonId);
		}

		public static Person? Find(this ITable<Person> table, int personId)
		{
			return table.FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Person?> FindAsync(this ITable<Person> table, int personId, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Person> FindQuery(this ITable<Person> table, int personId)
		{
			return table.Where(e => e.PersonId == personId);
		}

		public static Person? Find(this ITable<Person> table, Person @record)
		{
			return table.FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Person?> FindAsync(this ITable<Person> table, Person @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Person> FindQuery(this ITable<Person> table, Person @record)
		{
			return table.Where(e => e.PersonId == @record.PersonId);
		}

		public static Person? FindPerson(this TestDataDB db, int personId)
		{
			return db.GetTable<Person>().FirstOrDefault(e => e.PersonId == personId);
		}

		public static Task<Person?> FindPersonAsync(this TestDataDB db, int personId, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Person>().FirstOrDefaultAsync(e => e.PersonId == personId, cancellationToken);
		}

		public static IQueryable<Person> FindPersonQuery(this TestDataDB db, int personId)
		{
			return db.GetTable<Person>().Where(e => e.PersonId == personId);
		}

		public static Person? Find(this TestDataDB db, Person @record)
		{
			return db.GetTable<Person>().FirstOrDefault(e => e.PersonId == @record.PersonId);
		}

		public static Task<Person?> FindAsync(this TestDataDB db, Person @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<Person>().FirstOrDefaultAsync(e => e.PersonId == @record.PersonId, cancellationToken);
		}

		public static IQueryable<Person> FindQuery(this TestDataDB db, Person @record)
		{
			return db.GetTable<Person>().Where(e => e.PersonId == @record.PersonId);
		}

		public static TestIdentity? Find(this ITable<TestIdentity> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestIdentity?> FindAsync(this ITable<TestIdentity> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestIdentity> FindQuery(this ITable<TestIdentity> table, int id)
		{
			return table.Where(e => e.Id == id);
		}

		public static TestIdentity? Find(this ITable<TestIdentity> table, TestIdentity @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestIdentity?> FindAsync(this ITable<TestIdentity> table, TestIdentity @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestIdentity> FindQuery(this ITable<TestIdentity> table, TestIdentity @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static TestIdentity? FindTestIdentity(this TestDataDB db, int id)
		{
			return db.GetTable<TestIdentity>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestIdentity?> FindTestIdentityAsync(this TestDataDB db, int id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestIdentity>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestIdentity> FindTestIdentityQuery(this TestDataDB db, int id)
		{
			return db.GetTable<TestIdentity>().Where(e => e.Id == id);
		}

		public static TestIdentity? Find(this TestDataDB db, TestIdentity @record)
		{
			return db.GetTable<TestIdentity>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestIdentity?> FindAsync(this TestDataDB db, TestIdentity @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestIdentity>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestIdentity> FindQuery(this TestDataDB db, TestIdentity @record)
		{
			return db.GetTable<TestIdentity>().Where(e => e.Id == @record.Id);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestMerge1?> FindAsync(this ITable<TestMerge1> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestMerge1> FindQuery(this ITable<TestMerge1> table, int id)
		{
			return table.Where(e => e.Id == id);
		}

		public static TestMerge1? Find(this ITable<TestMerge1> table, TestMerge1 @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestMerge1?> FindAsync(this ITable<TestMerge1> table, TestMerge1 @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestMerge1> FindQuery(this ITable<TestMerge1> table, TestMerge1 @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static TestMerge1? FindTestMerge1(this TestDataDB db, int id)
		{
			return db.GetTable<TestMerge1>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestMerge1?> FindTestMerge1Async(this TestDataDB db, int id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestMerge1>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestMerge1> FindTestMerge1Query(this TestDataDB db, int id)
		{
			return db.GetTable<TestMerge1>().Where(e => e.Id == id);
		}

		public static TestMerge1? Find(this TestDataDB db, TestMerge1 @record)
		{
			return db.GetTable<TestMerge1>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestMerge1?> FindAsync(this TestDataDB db, TestMerge1 @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestMerge1>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestMerge1> FindQuery(this TestDataDB db, TestMerge1 @record)
		{
			return db.GetTable<TestMerge1>().Where(e => e.Id == @record.Id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, int id)
		{
			return table.FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestMerge2?> FindAsync(this ITable<TestMerge2> table, int id, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestMerge2> FindQuery(this ITable<TestMerge2> table, int id)
		{
			return table.Where(e => e.Id == id);
		}

		public static TestMerge2? Find(this ITable<TestMerge2> table, TestMerge2 @record)
		{
			return table.FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestMerge2?> FindAsync(this ITable<TestMerge2> table, TestMerge2 @record, CancellationToken cancellationToken = default)
		{
			return table.FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestMerge2> FindQuery(this ITable<TestMerge2> table, TestMerge2 @record)
		{
			return table.Where(e => e.Id == @record.Id);
		}

		public static TestMerge2? FindTestMerge2(this TestDataDB db, int id)
		{
			return db.GetTable<TestMerge2>().FirstOrDefault(e => e.Id == id);
		}

		public static Task<TestMerge2?> FindTestMerge2Async(this TestDataDB db, int id, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestMerge2>().FirstOrDefaultAsync(e => e.Id == id, cancellationToken);
		}

		public static IQueryable<TestMerge2> FindTestMerge2Query(this TestDataDB db, int id)
		{
			return db.GetTable<TestMerge2>().Where(e => e.Id == id);
		}

		public static TestMerge2? Find(this TestDataDB db, TestMerge2 @record)
		{
			return db.GetTable<TestMerge2>().FirstOrDefault(e => e.Id == @record.Id);
		}

		public static Task<TestMerge2?> FindAsync(this TestDataDB db, TestMerge2 @record, CancellationToken cancellationToken = default)
		{
			return db.GetTable<TestMerge2>().FirstOrDefaultAsync(e => e.Id == @record.Id, cancellationToken);
		}

		public static IQueryable<TestMerge2> FindQuery(this TestDataDB db, TestMerge2 @record)
		{
			return db.GetTable<TestMerge2>().Where(e => e.Id == @record.Id);
		}
		#endregion

		#region Associations
		#region Doctor Associations
		/// <summary>
		/// PersonDoctor
		/// </summary>
		[Association(CanBeNull = false, ThisKey = nameof(OleDb.Doctor.PersonId), OtherKey = nameof(Person.PersonId))]
		public static Person PersonDoctor(this Doctor obj, IDataContext db)
		{
			return db.GetTable<Person>().First(t => obj.PersonId == t.PersonId);
		}
		#endregion

		#region Person Associations
		/// <summary>
		/// PersonDoctor backreference
		/// </summary>
		[Association(ThisKey = nameof(Person.PersonId), OtherKey = nameof(OleDb.Doctor.PersonId))]
		public static Doctor? Doctor(this Person obj, IDataContext db)
		{
			return db.GetTable<Doctor>().FirstOrDefault(t => t.PersonId == obj.PersonId);
		}

		/// <summary>
		/// PersonPatient backreference
		/// </summary>
		[Association(ThisKey = nameof(Person.PersonId), OtherKey = nameof(OleDb.Patient.PersonId))]
		public static Patient? Patient(this Person obj, IDataContext db)
		{
			return db.GetTable<Patient>().FirstOrDefault(t => t.PersonId == obj.PersonId);
		}
		#endregion

		#region Patient Associations
		/// <summary>
		/// PersonPatient
		/// </summary>
		[Association(CanBeNull = false, ThisKey = nameof(OleDb.Patient.PersonId), OtherKey = nameof(Person.PersonId))]
		public static Person PersonPatient(this Patient obj, IDataContext db)
		{
			return db.GetTable<Person>().First(t => obj.PersonId == t.PersonId);
		}
		#endregion
		#endregion

		#region Stored Procedures
		#region AddIssue792Record
		public static int AddIssue792Record(this TestDataDB dataConnection)
		{
			return dataConnection.ExecuteProc("[AddIssue792Record]");
		}

		public static Task<int> AddIssue792RecordAsync(this TestDataDB dataConnection, CancellationToken cancellationToken = default)
		{
			return dataConnection.ExecuteProcAsync("[AddIssue792Record]", cancellationToken);
		}
		#endregion

		#region PatientSelectByName
		public static IEnumerable<PatientSelectByNameResult> PatientSelectByName(this TestDataDB dataConnection, string? firstName, string? lastName)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@lastName", lastName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				}
			};
			return dataConnection.QueryProc<PatientSelectByNameResult>("[Patient_SelectByName]", parameters);
		}

		public static Task<IEnumerable<PatientSelectByNameResult>> PatientSelectByNameAsync(this TestDataDB dataConnection, string? firstName, string? lastName, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@lastName", lastName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				}
			};
			return dataConnection.QueryProcAsync<PatientSelectByNameResult>("[Patient_SelectByName]", cancellationToken, parameters);
		}

		public partial class PatientSelectByNameResult
		{
			[Column("PersonID"  , DataType = DataType.Int32  , DbType = "Long"        )] public int?    PersonId   { get; set; }
			[Column("FirstName" , DataType = DataType.VarChar, DbType = "VarChar(50)" )] public string? FirstName  { get; set; }
			[Column("LastName"  , DataType = DataType.VarChar, DbType = "VarChar(50)" )] public string? LastName   { get; set; }
			[Column("MiddleName", DataType = DataType.VarChar, DbType = "VarChar(50)" )] public string? MiddleName { get; set; }
			[Column("Gender"    , DataType = DataType.VarChar, DbType = "VarChar(1)"  )] public char?   Gender     { get; set; }
			[Column("Diagnosis" , DataType = DataType.VarChar, DbType = "VarChar(255)")] public string? Diagnosis  { get; set; }
		}
		#endregion

		#region PersonDelete
		public static int PersonDelete(this TestDataDB dataConnection, int? personId)
		{
			var parameters = new []
			{
				new DataParameter("@PersonID", personId, DataType.Int32)
				{
					DbType = "Long"
				}
			};
			return dataConnection.ExecuteProc("[Person_Delete]", parameters);
		}

		public static Task<int> PersonDeleteAsync(this TestDataDB dataConnection, int? personId, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@PersonID", personId, DataType.Int32)
				{
					DbType = "Long"
				}
			};
			return dataConnection.ExecuteProcAsync("[Person_Delete]", cancellationToken, parameters);
		}
		#endregion

		#region PersonInsert
		public static int PersonInsert(this TestDataDB dataConnection, string? firstName, string? middleName, string? lastName, char? gender)
		{
			var parameters = new []
			{
				new DataParameter("@FirstName", firstName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@MiddleName", middleName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@LastName", lastName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@Gender", gender, DataType.NText)
				{
					DbType = "Text",
					Size = 1
				}
			};
			return dataConnection.ExecuteProc("[Person_Insert]", parameters);
		}

		public static Task<int> PersonInsertAsync(this TestDataDB dataConnection, string? firstName, string? middleName, string? lastName, char? gender, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@FirstName", firstName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@MiddleName", middleName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@LastName", lastName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@Gender", gender, DataType.NText)
				{
					DbType = "Text",
					Size = 1
				}
			};
			return dataConnection.ExecuteProcAsync("[Person_Insert]", cancellationToken, parameters);
		}
		#endregion

		#region PersonSelectByKey
		public static IEnumerable<PersonSelectByKeyResult> PersonSelectByKey(this TestDataDB dataConnection, int? id)
		{
			var parameters = new []
			{
				new DataParameter("@id", id, DataType.Int32)
				{
					DbType = "Long"
				}
			};
			return dataConnection.QueryProc<PersonSelectByKeyResult>("[Person_SelectByKey]", parameters);
		}

		public static Task<IEnumerable<PersonSelectByKeyResult>> PersonSelectByKeyAsync(this TestDataDB dataConnection, int? id, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@id", id, DataType.Int32)
				{
					DbType = "Long"
				}
			};
			return dataConnection.QueryProcAsync<PersonSelectByKeyResult>("[Person_SelectByKey]", cancellationToken, parameters);
		}

		public partial class PersonSelectByKeyResult
		{
			[Column("PersonID"  , DataType = DataType.Int32  , DbType = "Long"       )] public int     PersonId   { get; set; }
			[Column("FirstName" , DataType = DataType.VarChar, DbType = "VarChar(50)")] public string? FirstName  { get; set; }
			[Column("LastName"  , DataType = DataType.VarChar, DbType = "VarChar(50)")] public string? LastName   { get; set; }
			[Column("MiddleName", DataType = DataType.VarChar, DbType = "VarChar(50)")] public string? MiddleName { get; set; }
			[Column("Gender"    , DataType = DataType.VarChar, DbType = "VarChar(1)" )] public char?   Gender     { get; set; }
		}
		#endregion

		#region PersonSelectByName
		public static IEnumerable<PersonSelectByNameResult> PersonSelectByName(this TestDataDB dataConnection, string? firstName, string? lastName)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@lastName", lastName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				}
			};
			return dataConnection.QueryProc<PersonSelectByNameResult>("[Person_SelectByName]", parameters);
		}

		public static Task<IEnumerable<PersonSelectByNameResult>> PersonSelectByNameAsync(this TestDataDB dataConnection, string? firstName, string? lastName, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@lastName", lastName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				}
			};
			return dataConnection.QueryProcAsync<PersonSelectByNameResult>("[Person_SelectByName]", cancellationToken, parameters);
		}

		public partial class PersonSelectByNameResult
		{
			[Column("PersonID"  , DataType = DataType.Int32  , DbType = "Long"       )] public int     PersonId   { get; set; }
			[Column("FirstName" , DataType = DataType.VarChar, DbType = "VarChar(50)")] public string? FirstName  { get; set; }
			[Column("LastName"  , DataType = DataType.VarChar, DbType = "VarChar(50)")] public string? LastName   { get; set; }
			[Column("MiddleName", DataType = DataType.VarChar, DbType = "VarChar(50)")] public string? MiddleName { get; set; }
			[Column("Gender"    , DataType = DataType.VarChar, DbType = "VarChar(1)" )] public char?   Gender     { get; set; }
		}
		#endregion

		#region PersonSelectListByName
		public static IEnumerable<PersonSelectListByNameResult> PersonSelectListByName(this TestDataDB dataConnection, string? firstName, string? lastName)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@lastName", lastName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				}
			};
			return dataConnection.QueryProc<PersonSelectListByNameResult>("[Person_SelectListByName]", parameters);
		}

		public static Task<IEnumerable<PersonSelectListByNameResult>> PersonSelectListByNameAsync(this TestDataDB dataConnection, string? firstName, string? lastName, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@firstName", firstName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@lastName", lastName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				}
			};
			return dataConnection.QueryProcAsync<PersonSelectListByNameResult>("[Person_SelectListByName]", cancellationToken, parameters);
		}

		public partial class PersonSelectListByNameResult
		{
			[Column("PersonID"  , DataType = DataType.Int32  , DbType = "Long"       )] public int     PersonId   { get; set; }
			[Column("FirstName" , DataType = DataType.VarChar, DbType = "VarChar(50)")] public string? FirstName  { get; set; }
			[Column("LastName"  , DataType = DataType.VarChar, DbType = "VarChar(50)")] public string? LastName   { get; set; }
			[Column("MiddleName", DataType = DataType.VarChar, DbType = "VarChar(50)")] public string? MiddleName { get; set; }
			[Column("Gender"    , DataType = DataType.VarChar, DbType = "VarChar(1)" )] public char?   Gender     { get; set; }
		}
		#endregion

		#region PersonUpdate
		public static int PersonUpdate(this TestDataDB dataConnection, int? id, int? personId, string? firstName, string? middleName, string? lastName, char? gender)
		{
			var parameters = new []
			{
				new DataParameter("@id", id, DataType.Int32)
				{
					DbType = "Long"
				},
				new DataParameter("@PersonID", personId, DataType.Int32)
				{
					DbType = "Long"
				},
				new DataParameter("@FirstName", firstName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@MiddleName", middleName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@LastName", lastName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@Gender", gender, DataType.NText)
				{
					DbType = "Text",
					Size = 1
				}
			};
			return dataConnection.ExecuteProc("[Person_Update]", parameters);
		}

		public static Task<int> PersonUpdateAsync(this TestDataDB dataConnection, int? id, int? personId, string? firstName, string? middleName, string? lastName, char? gender, CancellationToken cancellationToken = default)
		{
			var parameters = new []
			{
				new DataParameter("@id", id, DataType.Int32)
				{
					DbType = "Long"
				},
				new DataParameter("@PersonID", personId, DataType.Int32)
				{
					DbType = "Long"
				},
				new DataParameter("@FirstName", firstName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@MiddleName", middleName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@LastName", lastName, DataType.NText)
				{
					DbType = "Text",
					Size = 50
				},
				new DataParameter("@Gender", gender, DataType.NText)
				{
					DbType = "Text",
					Size = 1
				}
			};
			return dataConnection.ExecuteProcAsync("[Person_Update]", cancellationToken, parameters);
		}
		#endregion
		#endregion
	}
}