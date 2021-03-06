﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StarWars5e.Models.Utils
{
    public static class ListExtensions
    {
        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }

        public static int FindNthIndex<T>(this List<T> source, Predicate<T> searchValue, int selection)
        {
            if (selection < 1)
                throw new NotSupportedException("Param 'selection' must be greater than 0!");

            if (selection == 1)
                return source.FindIndex(searchValue);

            var index = 0;
            for(var i = 1; i <= selection; i++)
            {
                index = source.FindIndex(index + 1, searchValue);
                if (index == -1) return index;
            }

            return index;
        }

        public static List<int> FindAllIndexOf<T>(this List<T> source, Predicate<T> match)
        {
            return source.Select((value, index) => match(value) ? index : -1)
                .Where(index => index != -1).ToList();
        }
    }
}
