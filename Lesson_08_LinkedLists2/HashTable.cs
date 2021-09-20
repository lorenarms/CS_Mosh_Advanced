using System;
using static System.Console;

interface IntSet
{
	void add(int i, bool count = false);  // add a number to a set, if not already present
	void remove(int i);  // remove a number, if present in the set
	bool contains(int i);  // return true if i is in the set
						   //int count;  // return the number of values in the set
}

class List
{
	class Node
	{
		public int val;
		public Node next = null;
		public Node(int val, Node next)
		{
			this.val = val;
			this.next = next;
		}
	}

	Node head = null;
	Node stream = null;
	int length = 0;

	public void prepend(int i)
	{
		Node n = new Node(i, head);
		head = n;
		length++;
	}

	// if int i is found in list:
	//   out variable 'node' points to the Node containing i
	//   out variable 'prev' points to the Node which points to 'node'
	//     unless 'node' is head, in which case 'prev' is null
	//   returns true
	public bool Find(int i, out Node node, out Node prev)
	{
		node = prev = null;
		Node curr = new Node(0, head); // useful purely for iteration
		while (curr.next != null && curr.next.val != i)
			curr = curr.next;
		if (curr.next == null) return false; // not in list
		prev = curr.next == head ? null : curr;
		node = curr.next;
		return true;
	}

	public bool erase(int i)
	{
		bool valueWasFound = Find(i, out Node node, out Node prev);
		if (!valueWasFound) WriteLine("value not found!");
		if (!valueWasFound) return false;
		if (prev == null)
			head = node.next;
		else
			prev.next = node.next;
		node.next = null;
		length--;
		return true;
	}

	public void reset() { stream = head; }

	public int? next()
	{
		if (stream == null) return null;
		int i = stream.val;
		stream = stream.next;
		return i;
	}

}

class Hash : IntSet
{
	List[] buckets;
	int capacity = 2;
	int maxLoadFactor = 5;
	public int count = 0;

	public Hash() { buckets = new List[capacity]; }

	int hash(int i) => i % capacity;

	void rehash()
	{
		List[] oldBuckets = buckets;

		capacity = capacity * 2;
		buckets = new List[capacity];
		for (int i = 0; i < oldBuckets.Length; i++)
		{
			oldBuckets[i].reset();
			while (oldBuckets[i].next() is int a)
			{
				//if ( hash(a) == i ) continue;
				this.add(a, false);
			}
		}
	}

	public void add(int i, bool count = true)
	{
		if (this.count >= maxLoadFactor * capacity)
			rehash();

		int index = hash(i);
		// create new list if bucket equals null
		buckets[index] = buckets[index] ?? new List();
		buckets[index].prepend(i);
		if (count)
			this.count++;
	}

	public void remove(int i)
	{
		int index = hash(i);
		if (buckets[index].erase(i)) count--;
	}

	public bool contains(int i)
	{
		int index = hash(i);
		buckets[index] = buckets[index] ?? new List();
		return buckets[index].Find(i, out Node node, out Node prev);
	}
}