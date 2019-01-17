using System;

static LList MergeTwoLinkedList(LList list, LList listB)
{
    Node node = list.Current.Next;
    Node nodeB = listB.Current.Next;

    list.Current = list.Head;
    listB.Current = listB.Head;

    while (node != null || nodeB != null)
    {

        list.Current.Next = listB.Current;
        list.Current.Next = node;

        list.Current = node;
        listB.Current = nodeB;

        if (list.Current != null) node = list.Current.Next;
        if (listB.Current != null) nodeB = listB.Current.Next;

    }
    if (node == null)
    {
        list.Current.Next = listB.Current;
    }

    list.Current = list.Head;

    return list;
}
