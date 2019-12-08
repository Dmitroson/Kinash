#include <iostream>
#include <cmath>

using namespace std;

template <typename T>
class Queue {
private:
	template <typename T>
	class Node {
	public:
		Node* pNext;
		T data;

		Node(T data = T(), Node* pNext = nullptr) {
			this->data = data;
			this->pNext = pNext;
		}
	};
public:
	int Size;
	Node<T>* head;

	int GetSize() {
		return Size;
	}

	T& operator[](const int index) {
		int counter = 0;
		Node<T>* current = this->head;
		while (current != nullptr) {
			if (counter == index) {
				return current->data;
			}
			current = current->pNext;
			counter++;
		}
	}

	Queue() {
		Size = 0;
		head = nullptr;
	}

	void Add(T data) {
		if (head == nullptr) {
			head = new Node<T>(data);
		}
		else {
			Node<T>* current = this->head;
			while (current->pNext != nullptr) {
				current = current->pNext;
			}
			current->pNext = new Node<T>(data);
		}
		Size++;
	}

	void DeleteFront() {
		Node<T>* temp = head;
		head = head->pNext;
		delete temp;
		Size--;
	}
	
	void Show() {
		Node<T>* current = this->head;
		while (current != nullptr) {
			cout << current->data << " ";
			current = current->pNext;
		}
		cout << endl;
	}

	bool CheckForGrowth() {
		Node<T>* current = this->head;
		T currentData = current->data;
		while (current->pNext != nullptr) {
			if (current->data <= current->pNext->data) {
				current = current->pNext;
			}
			else {
				return false;
			}
		}
		return true;
	}

	bool CheckForFall() {
		Node<T>* current = this->head;
		T currentData = current->data;
		while (current->pNext != nullptr) {
			if (current->data >= current->pNext->data) {
				current = current->pNext;
			}
			else {
				return false;
			}
		}
		return true;
	}

	void Clear() {
		while (Size) {
			DeleteFront();
		}
	}

	void Check() {
		if (CheckForGrowth() || CheckForFall()) {
			cout << "Queue sorted\n";
		}
		else {
			cout << "Queue is not sorted\n";
		}
	}

	~Queue() {
		Clear();
	}
};

int main() {
	Queue<int> q;
	
	q.Add(5);
	q.Add(10);
	q.Add(20);
	q.Add(30);

	q.Show();
	q.DeleteFront();
	q.Show();
	q.Check();


	q.Add(15);
	q.Show();
	q.Check();
	return 0;

}