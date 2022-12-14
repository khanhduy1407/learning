#include<stdio.h>

#define MAX 100

int daDuyet[MAX], thuTuDuyet[MAX], nTTD = 0;

void khoiTao() {
	nTTD = 0;
	for (int i = 0; i < 100; i++) {
		daDuyet[i] = 0;
	}
}

struct DOTHI {
	int soDinh;
	int a[MAX][MAX];
};

int DocMaTranKe(DOTHI &g) {
	// doc file
	FILE* f;
	f = fopen("./Test1_01.txt", "rt");
	if (f == NULL) {
		printf("Khong mo duoc file!\n");
		return 0;
	}
	
	fscanf(f, "%d", &g.soDinh);
	
	int i, j;
	for (i = 0; i < g.soDinh; i++) {
		for (j = 0; j < g.soDinh; j++) {
			fscanf(f, "%d", &g.a[i][j]);
		}
	}
	
	fclose(f);
	
	return 1;
}

void XuatMaTranKe(DOTHI g) {
	printf("So dinh cua do thi la %d\n", g.soDinh);
	
	printf("Ma tran ke cua do thi la:\n");
	for (int i = 0; i < g.soDinh; i++) {
		printf("\t");
		for (int j = 0; j < g.soDinh; j++) {
			printf("%d ", g.a[i][j]);
		}
		printf("\n");
	}
}

void lietKeThuTuDuyet() {
	for (int i = 0; i < nTTD; i++)
		printf("%d ", thuTuDuyet[i]);
}

void DFS(int S, DOTHI g) {
	daDuyet[S] = 1; // danh dau da duyet dinh S
	thuTuDuyet[nTTD++] = S; // bo dinh S vao thuTuDuyet
	for (int i = 0; i < g.soDinh; i++) {
		if (g.a[S][i] != 0 && daDuyet[i] == 0) {
			daDuyet[i] = 1;
			DFS(i, g);
		}
	}
}

int lay1PTTuHangDoi(int Q[], int &nQ) {
	int U = Q[0];
	for (int i = 0; i < nQ - 1; i++)
		Q[i] = Q[i+1];
	nQ--; // giam so phan tu cua Q
	return U;
}

void BFS(int S, DOTHI g) {
	int Q[MAX], nQ = 0; // khai bao va khoi tao QUEUE
	daDuyet[S] = 1; // danh dau da duyet dinh S
	thuTuDuyet[nTTD++] = S; // bo dinh S vao thuTuDuyet
	Q[nQ++] = S; // bo S vao QUEUE 
	int U;
	while (nQ != 0) {
		U = lay1PTTuHangDoi(Q, nQ);
		for (int i = 0; i < g.soDinh; i++) {
			if (g.a[U][i] != 0 && daDuyet[i] == 0) {
				daDuyet[i] = 1; // danh dau da duyet i
				thuTuDuyet[nTTD++] = i;
				Q[nQ++] = i; // bo i vao hang doi
			}
		}
	}
}

int main() {
	DOTHI g;
	DocMaTranKe(g);
	XuatMaTranKe(g);
	
	int S;
	printf("Nhap vao dinh xuat phat: "); scanf("%d", &S);
	
	khoiTao();
	DFS(S, g);
	printf("DFS: ");
	lietKeThuTuDuyet();
	
	khoiTao();
	BFS(S, g);
	printf("\nBFS: ");
	lietKeThuTuDuyet();
}
