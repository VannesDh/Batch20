using Exercise5Week4;

CircularQueue queue = new CircularQueue(3);

queue.Log(10);
queue.Log(20);
queue.Log(30);

queue.SetOverwritePolicy(false);

queue.Log(40);

queue.Read();
queue.Read();
queue.Read();