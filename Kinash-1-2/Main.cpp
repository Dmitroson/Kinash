#include <iostream>
#include <cmath>

using namespace std;

class Vector
{
private:
	int NumberOfVectors = 3;
	int* Coords = new int[NumberOfVectors];

public:
	Vector() {
		fill(Coords, Coords + NumberOfVectors, 0);
	}

	Vector(int coordX, int coordY, int coordZ) {
		Coords[0] = coordX;
		Coords[1] = coordY;
		Coords[2] = coordZ;
	}

	Vector(const Vector &obj) {
		Coords[0] = obj.Coords[0];
		Coords[1] = obj.Coords[1];
		Coords[2] = obj.Coords[2];
	}

	~Vector() {
		delete[] Coords;
	}

	friend istream& operator >> (istream&, Vector&);
	friend ostream& operator << (ostream&, Vector&);
	
	Vector operator + (Vector& vector) {
		return Vector(this->Coords[0] + vector.Coords[0], this->Coords[1] + vector.Coords[1], this->Coords[2] + vector.Coords[2]);
	}

	Vector operator - (Vector& vector) {
		return Vector(this->Coords[0] - vector.Coords[0], this->Coords[1] - vector.Coords[1], this->Coords[2] - vector.Coords[2]);
	}

	int operator * (Vector& vector) {
		return (this->Coords[0] * vector.Coords[0]) + (this->Coords[1] * vector.Coords[1]) + (this->Coords[2] * vector.Coords[2]);
	}

	Vector operator * (int number) {
		return Vector(this->Coords[0] * number, this->Coords[1] * number, this->Coords[2] * number);
	}

	int& operator [] (const int index) {
		return Coords[index];
	}

	int GetCoordX() {
		return Coords[0];
	}

	int GetCoordY() {
		return Coords[1];
	}

	int GetCoordZ() {
		return Coords[2];
	}

	void SetCoordX(int coordX) {
		Coords[0] = coordX;
	}

	void SetCoordY(int coordY) {
		Coords[1] = coordY;
	}

	void SetCoordZ(int coordZ) {
		Coords[2] = coordZ;
	}
};

istream& operator>> (istream& in, Vector& vector) {
	for (int i = 0; i < vector.NumberOfVectors; i++) {
		in >> vector.Coords[i];
	}
	return in;
}

ostream& operator<< (ostream& out, Vector& vector) {
	for (int i = 0; i < vector.NumberOfVectors; i++) {
		out << "Coord " << i + 1 << " = " << vector.Coords[i] << endl;
	}
	return out;
}

int main() {
	Vector v1 = Vector(5, 4, 6);
	Vector v2;
	cout << "Enter 3 coordinates\n";
	cin >> v2;
	cout << v2;
	
	cout << endl;
	
	Vector v3 = v1 + v2;
	cout << "Sum of two vectors:\n" << v3;
	cout << endl;

	Vector v4 = v1 - v2;
	cout << "Difference of two vectors:\n" << v4;
	cout << endl;

	cout << (v1 * v2);
	cout << endl << endl;
	Vector v5 = v1 * 5;
	cout << v5;
	cout << endl;

	v5[0] = 1000;
	cout << v5;

	return 0;
}