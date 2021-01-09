
            int[] result = item.ToString().Select(o=>Convert.ToInt32(o)).ToArray();
            Console.WriteLine(result.Length);