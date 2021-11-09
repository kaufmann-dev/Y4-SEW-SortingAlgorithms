using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Sorting.Model
{
    public class Sort
    {
        public static (List<int>, string, string) Bubble (List<int> list)
        {
            int[] arr = list.ToArray();
            
            Stopwatch timer = Stopwatch.StartNew();
            
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                // bubble up
                for (int j = 0; j <= i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                        Swap(arr, j, j + 1);
                }
            }

            timer.Stop();  
            long timeSpan = timer.ElapsedMilliseconds;
            string timeSpanString = timeSpan.ToString();
            
            return (arr.ToList(), timeSpanString, DateTime.Now.ToString());
        }
        
        public static (List<int>, string, string) Insertion(List<int> list)
        {
            int[] arr = list.ToArray();
            
            Stopwatch timer = Stopwatch.StartNew();

            for (int i = 1; i < arr.Length; i++)
            {
                // a temporary copy of the current element
                int tmp = arr[i];
                int j;
 
                // find the position for insertion
                for (j = i; j > 0; j--)
                {
                    if (arr[j - 1] < tmp)
                        break;
                    // shift the sorted part to right
                    arr[j] = arr[j - 1];
                }
 
                // insert the current element
                arr[j] = tmp;
            }

            timer.Stop();  
            long timeSpan = timer.ElapsedMilliseconds;
            string timeSpanString = timeSpan.ToString();

            return (arr.ToList(), timeSpanString, DateTime.Now.ToString());
        }
        public static (List<int>, string, string) Selection(List<int> list)
        {
            int[] arr = list.ToArray();
            
            Stopwatch timer = Stopwatch.StartNew();
            
            // find the smallest element starting from position i
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;  // record the position of the smallest
                for (int j = i + 1; j < arr.Length; j++)
                {
                    // update min when finding a smaller element
                    if (arr[j] < arr[min])
                        min = j;
                }
 
                // put the smallest element at position i
                Swap(arr, i, min);
            }
            
            timer.Stop();  
            long timeSpan = timer.ElapsedMilliseconds;
            string timeSpanString = timeSpan.ToString();

            return (arr.ToList(), timeSpanString, DateTime.Now.ToString());
        }
        public static void Swap (int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}