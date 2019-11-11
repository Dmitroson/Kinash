#include <iostream>
#include <cmath>
#include "windows.h"

using namespace std;

class Vector
{
private:
	int NumberOfVectors = 3;
	int* Coords = new int[NumberOfVectors];

public:
	Vector() {
		fill(Coords, Coords + NumberOfVectors, 1);
	}

	Vector(int coordX, int coordY, int coordZ) {
		Coords[0] = coordX;
		Coords[1] = coordY;
		Coords[2] = coordZ;
	}

	~Vector() { }

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

	void PrintElementOfVector() {
		for (int i = 0; i < NumberOfVectors; i++) {
			cout << "Coord " << i+1 << " = " << Coords[i] << endl;
		}
	}

	double LenghtVector() {
		return sqrt(pow(Coords[0], 2) + pow(Coords[1], 2) + pow(Coords[2], 2));
	}

	void SumOfVectors(Vector vector1, Vector vector2) {
		SetCoordX(vector1.GetCoordX() + vector2.GetCoordX());
		SetCoordY(vector1.GetCoordY() + vector2.GetCoordY());
		SetCoordZ(vector1.GetCoordZ() + vector2.GetCoordZ());
	}

	void DifferenceOfVectors(Vector vector1, Vector vector2) {
		SetCoordX(vector1.GetCoordX() - vector2.GetCoordX());
		SetCoordY(vector1.GetCoordY() - vector2.GetCoordY());
		SetCoordZ(vector1.GetCoordZ() - vector2.GetCoordZ());
	}

	friend int ScalarProduct(Vector vector1, Vector vector2) {
		int scalarProduct = (vector1.GetCoordX() * vector2.GetCoordX()) +
			(vector1.GetCoordY() * vector2.GetCoordY()) +
			(vector1.GetCoordZ() * vector2.GetCoordZ());
		return scalarProduct;
	}

	
};


int main() {
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	// ��������� ��� ��'���� ���� Vector �� ��������� ������������.
	Vector v1 = Vector(5, 4, 6);
	Vector v2 = Vector(3, 3, 3);

	// �������� � ������� �� ���������� �������.
	v1.PrintElementOfVector();
	cout << endl;
	v2.PrintElementOfVector();

	cout << endl;

	// �������� � ������� ������� �������.
	cout << "������� �������:\n";
	cout << v1.LenghtVector() << endl;
	cout << v2.LenghtVector();

	cout << endl << endl;

	// ������ ���� ���� �������, ��������� ����� ������.
	Vector vs;
	cout << "���� �������:\n";
	vs.SumOfVectors(v1, v2);
	vs.PrintElementOfVector();

	cout << endl;

	// ������ ������ ���� �������, ��������� ����� ������.
	Vector vd;
	cout << "г����� �������:\n";
	vd.DifferenceOfVectors(v1, v2);
	vd.PrintElementOfVector();

	cout << endl;

	// �������� � ������� ��������� ������� ���� �������.
	cout << "��������� ������� ���� �������: " << ScalarProduct(v1, v2);

	return 0;
}