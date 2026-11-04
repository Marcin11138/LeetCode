using System.Collections;

class Sum
{
    static void Main(string[] args)
    {
        int[] nums = [-1, 0, 1, 2, -1, -4, -2, -3, 3, 0, 4];

        var result = MyFunction(nums);

        foreach (List<int> item in result)
        {
           
           System.Console.WriteLine(item[0] + " " + item[1] + " " + item[2]);
        }
    }
    
    static IList<IList<int>> MyFunction(int[] nums)
    {
        Dictionary<int, int> hashtable = new();
        IList<IList<int>> result = new List<IList<int>>();
       
        foreach (int num in nums)
        {
            if (!hashtable.ContainsKey(num))
            {
                hashtable.Add(num, 1);
            }
            else
            {
                hashtable[num] = hashtable[num] + 1;
            }
        }


        
        for (int i = 0; i < nums.Length; i++)
        {
            
            int a = nums[i];

            for (int y = 0; y < nums.Length; y++)
            {
                if(i == y)
                {
                    continue;
                }
                int b = nums[y];

                int sum = a + b;
                int difference = 0 - sum;
                if (hashtable.ContainsKey(difference))
                {
                    List<int> list = new();
                    list.Add(a);
                    list.Add(b);
                    list.Add(difference);


                    if (difference == a)
                    {

                        if (hashtable[difference] <= 1)
                        {
                            continue;
                        }

                    }
                    if (difference == b)
                    {

                        if(hashtable[difference] <= 1)
                        {
                            continue;
                        }
                    }

                    if (hashtable[difference] == 1)
                    {
                        hashtable.Remove(difference);
                    }
                    else
                    {
                        hashtable[difference] = hashtable[difference] - 1;
                    }

                    bool duplicate = false;
                    foreach (var item in result)
                    {
                        if (item.Contains(a) && item.Contains(b) && item.Contains(difference))
                        {
                            System.Console.WriteLine(a + " " + b + " " + difference);
                            duplicate = true;
                            break;
                        }

                    }

                    if (!duplicate)
                    {
                        result.Add(list);

                    }


                }   
            }

        }


        return result;

    }
}