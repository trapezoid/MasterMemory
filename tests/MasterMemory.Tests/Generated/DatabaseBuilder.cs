// <auto-generated />
using MasterMemory.Tests.TestStructures;
using MasterMemory.Tests;
using MasterMemory.Validation;
using MasterMemory;
using MessagePack;
using System.Collections.Generic;
using System.Text;
using System;
using MasterMemory.Tests.Tables;

namespace MasterMemory.Tests
{
   public sealed class DatabaseBuilder : DatabaseBuilderBase
   {
        public DatabaseBuilder() : this(null) { }
        public DatabaseBuilder(MessagePack.IFormatterResolver resolver) : base(resolver) { }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<QuestMaster> dataSource)
        {
            AppendCore(dataSource, x => x.QuestId, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<ItemMaster> dataSource)
        {
            AppendCore(dataSource, x => x.ItemId, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<QuestMasterEmptyValidate> dataSource)
        {
            AppendCore(dataSource, x => x.QuestId, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<ItemMasterEmptyValidate> dataSource)
        {
            AppendCore(dataSource, x => x.ItemId, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<SequentialCheckMaster> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<SingleMaster> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<Fail> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<Sample> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<SkillMaster> dataSource)
        {
            AppendCore(dataSource, x => (x.SkillId, x.SkillLevel), System.Collections.Generic.Comparer<(int SkillId, int SkillLevel)>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<TestMaster> dataSource)
        {
            AppendCore(dataSource, x => x.TestID, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<UserLevel> dataSource)
        {
            AppendCore(dataSource, x => x.Level, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

    }
}