// <auto-generated />
using MasterMemory.Tests.TestStructures;
using MasterMemory.Validation;
using MasterMemory;
using MessagePack;
using System.Collections.Generic;
using System.Text;
using System;

namespace MasterMemory.Tests.Tables
{
   public sealed partial class TestMasterTable : TableBase<TestMaster>, ITableUniqueValidate
   {
        readonly Func<TestMaster, int> primaryIndexSelector;


        public TestMasterTable(TestMaster[] sortedData)
            : base(sortedData)
        {
            this.primaryIndexSelector = x => x.TestID;
        }


        public RangeView<TestMaster> FindByTestID(int key)
        {
            return FindManyCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<int>.Default, key);
        }

        public RangeView<TestMaster> FindClosestByTestID(int key, bool selectLower = true)
        {
            return FindManyClosestCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<int>.Default, key, selectLower);
        }

        public RangeView<TestMaster> FindRangeByTestID(int min, int max, bool ascendant = true)
        {
            return FindManyRangeCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<int>.Default, min, max, ascendant);
        }


        void ITableUniqueValidate.ValidateUnique(ValidateResult resultSet)
        {
        }

        public static MasterMemory.Meta.MetaTable CreateMetaTable()
        {
            return new MasterMemory.Meta.MetaTable(typeof(TestMaster), typeof(TestMasterTable), "TestMaster",
                new MasterMemory.Meta.MetaProperty[]
                {
                    new MasterMemory.Meta.MetaProperty(typeof(TestMaster).GetProperty("TestID")),
                    new MasterMemory.Meta.MetaProperty(typeof(TestMaster).GetProperty("Value")),
                },
                new MasterMemory.Meta.MetaIndex[]{
                    new MasterMemory.Meta.MetaIndex(new System.Reflection.PropertyInfo[] {
                        typeof(TestMaster).GetProperty("TestID"),
                    }, true, false, System.Collections.Generic.Comparer<int>.Default),
                });
        }
    }
}