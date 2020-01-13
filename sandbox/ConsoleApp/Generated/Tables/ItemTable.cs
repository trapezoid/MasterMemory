// <auto-generated />
using ConsoleApp;
using MasterMemory.Validation;
using MasterMemory;
using MessagePack;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Linq;
using System;

namespace ConsoleApp.Tables
{
   public sealed partial class ItemTable : TableBase<Item>, ITableUniqueValidate
   {
        readonly Func<Item, int> primaryIndexSelector;


        public ItemTable(Item[] sortedData)
            : base(sortedData)
        {
            this.primaryIndexSelector = x => x.RewardId;
        }


        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public Item FindByRewardId(int key)
        {
            var lo = 0;
            var hi = data.Length - 1;
            while (lo <= hi)
            {
                var mid = (int)(((uint)hi + (uint)lo) >> 1);
                var selected = data[mid].RewardId;
                var found = (selected < key) ? -1 : (selected > key) ? 1 : 0;
                if (found == 0) { return data[mid]; }
                if (found < 0) { lo = mid + 1; }
                else { hi = mid - 1; }
            }
            return default;
        }

        public Item FindClosestByRewardId(int key, bool selectLower = true)
        {
            return FindUniqueClosestCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<int>.Default, key, selectLower);
        }

        public RangeView<Item> FindRangeByRewardId(int min, int max, bool ascendant = true)
        {
            return FindUniqueRangeCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<int>.Default, min, max, ascendant);
        }


        void ITableUniqueValidate.ValidateUnique(ValidateResult resultSet)
        {
            ValidateUniqueCore(data, primaryIndexSelector, "RewardId", resultSet);       
        }
    }
}