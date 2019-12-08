#include <iostream>
#include <queue>

using namespace std;

int main() {
	queue<int> q;
	queue<int> q2;
	queue<int> q3;

	q.push(2);
	q.push(1);
	q.push(3);
	q.push(4);

	q.pop();
	//q.push(1);

	q3 = q2 = q;

	while (!q.empty()) {
		cout << q.front() << " ";
		q.pop();
	}

	cout << endl;

	bool f1 = true, f2 = true;

	int current1 = q2.front();
	int current2 = q2.front();
	

	while (!q2.empty()) {
		
		if (current1 < q2.front()) {
			current1 = q2.front();
			q2.pop();
		}
		else {
			f1 = false;
			break;
		}
	}

	while (!q2.empty()) {

		if (current1 > q2.front()) {
			current1 = q2.front();
			q2.pop();
		}
		else {
			f2 = false;
			break;
		}
	}

	if (f1 || f2) {
		cout << "Sorted";
	}
	else {
		cout << "Not Sorted";
	}


	return 0;
}