#include <iostream>
#include <fstream>
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

	friend istream& operator >> (istream&, Queue<T>&);
	friend ostream& operator << (ostream&, Queue<T>&);

	~Queue() {
		Clear();
	}
};

class NotCorrect { };

istream& operator >> (istream& is, Queue<int>& q) {
	int value;
	
	for (int i = 0; i < 5; i++) {
		if (!(is >> value)) {
			throw NotCorrect();
		}
		q.Add(value);
	}
	return is;
}

ostream& operator << (ostream& os, Queue<int>& q) {
	for (int i = 0; i < 5; i++) {
		os << q[i] << " ";
	}
	return os;
}

int main() {
	Queue<int> q;

	ofstream ofile;
	ofile.open("queue.txt");
	try {
		cin >> q;
		ofile << q << endl;
	}
	catch(NotCorrect){
		cin.clear();
		cin.sync();
	}
	ofile.close();


	ifstream ifile;
	ifile.open("queue.txt");
	cout << "\nThe content of the queue:\n";
	try {
		ifile >> q;
	}
	catch (NotCorrect) {

	}
	cout << q << endl;
	ifile.close();

	return 0;
}