
#include<bits/stdc++.h>
using namespace std;

struct Node {
    int data;
    Node* next;

    Node(int x){
        data = x;
        next = NULL;
    }
};

class Solution {
  public:
    Solution(){

    }
    int length(Node* head)
    {
        Node* curr = head;
        int res = 0;
        while(curr!=NULL)
        {
            res++;
            curr=curr->next;
        }
        return res;
    }
    Node* merge(Node* l,Node* r)
    {
        if(l==NULL)
            return r;
        if(r==NULL)
            return l;
        Node* l1=l;
        Node* r1= r;
        Node *res = l1->data<=r1->data?l1:r1;
        
        Node *c = res;
        
        while(l1!=NULL && r1!=NULL)
        {
            if(l1->data <= r1->data)
            {
                c->next = l1;
                l1=l1->next;
            }
            else{
                c->next = r1;
                r1=r1->next;
            }
            c=c->next;
        }
        return res;
    }
    Node* MergeSortRec(Node* head,int n)
    {
        int p = (n-1)/2;
        Node* curr = head;
        for(int i=1;i<=p;i++)
            curr = curr->next;
        Node *x = curr->next;
        curr->next = NULL;
        return merge(MergeSortRec(head,p),MergeSortRec(x,n-p));
    }
    Node* mergeSort(Node* head) {
        int n = length(head);
        
        return MergeSortRec(head,n);
    }
};
int main(){
    Node *head;
    Node * arr = new Node(4);
    head = arr;
    arr->next = new Node(1);
    arr = arr->next;
    arr->next = new Node(7);
    arr = arr->next;
    arr->next = new Node(3);
    arr = arr->next;
    arr->next = new Node(11);
    arr = arr->next;
    arr->next = new Node(9);
    arr = arr->next;

    Solution sol;
    head = sol.mergeSort(head);
    Node *temp = head;
    while(temp!=NULL)
    {
        cout<<temp->data<<" ";
        temp=temp->next;
    }
    return 0;

}