//namespace Tree
//{
//    internal class ParallelAndBatchTask
//    {
//        public void PerformBatchAndParallelOperations(int n, int batchSize, int parallelCount)
//        {
//            var batches = GetBatches(n, batchSize);
//            //var startTime = DateTime.Now;
//            //ExecuteBatches(batches);
//            //var endTime = DateTime.Now;
//            //Console.WriteLine();
//            //Console.WriteLine($"Time taken for synchronous execution {endTime - startTime}");
//            var startTimeP = DateTime.Now;
//            try
//            {
//               ExecuteParallelTasks(batches, parallelCount);
//            }
//            catch (Exception e)
//            {
//                if(e is AggregateException agex)
//                {
//                    foreach(var inner in agex.InnerExceptions)
//                    {
//                        Console.WriteLine(inner.Message);
//                    }
//                }
//            }
//            var endTimeP = DateTime.Now;
//            Console.WriteLine();
//            Console.WriteLine($"Time taken for parallel execution {endTimeP-startTimeP}");

//        }
//        private List<List<int>> GetBatches(int n, int batchSize)
//        {
//            int noOfBatches = (int)Math.Ceiling(1.0 * n / batchSize);
//            return Enumerable.Range(1, n).ToList().GroupBy((i) => (i-1) / batchSize).Select(g => g.ToList()).ToList();
//        }
//        private void ExecuteParallelTasks(List<List<int>> batches , int parallelCount)
//        {
//            CancellationTokenSource ctc = new();
//            var token = ctc.Token;
//            //ParallelOptions options = new()
//            //{
//            //    MaxDegreeOfParallelism = parallelCount,
//            //    CancellationToken = ctc.Token
//            //};
//            Parallel.ForEachAsync(batches, (batch,token) =>
//            {
//                try
//                {
//                    foreach (int p in batch)
//                    {

//                        if (p == 10)
//                        {
//                            throw new ArgumentException(p.ToString());
//                            //ctc.Cancel();
//                        }
//                        //options.CancellationToken.ThrowIfCancellationRequested();
//                        Console.Write(p + " ");
//                    }
//                }
//                catch(Exception e)
//                {
//                    ctc.Cancel();
                    
//                    throw e;
//                }
//                //Console.WriteLine();
//            });
//        }

//        private async Task ExecuteParallelTasks2(List<List<int>> batches, int parallelCount)
//        {
//            CancellationTokenSource ctc = new();
            
//            var tasks = batches.Select(batch => Task.Run<int>(() =>
//            {
//                try
//                {
                    
//                    ctc.Token.ThrowIfCancellationRequested();
//                    foreach (var b in batch)
//                    {
//                        if (b == 12)
//                            throw new ArgumentException(b.ToString());
//                        Console.Write(b + " ");
//                    }
//                    return 0;
//                }
//                catch(Exception e)
//                {
//                    ctc.Cancel();
//                    throw e;
//                }
//            })).ToList();
//            await Task.WhenAll(tasks);
//        }
//        private void ExecuteBatches(List<List<int>> batches)
//        {
//            foreach(var b in batches)
//            {
//                foreach(var p in b)
//                {
//                    Console.Write(p + " ");
//                }
//            }
//        }
//    }
//}
