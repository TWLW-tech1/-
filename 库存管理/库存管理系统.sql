create DataBase ���п��;

create table �˻�
(
	�˺� varchar(100) PRIMARY KEY NOT NULL,
	���� varchar(20)
)

CREATE TABLE ��Ʒ (
    ��Ʒ��� INT PRIMARY KEY,
    Ա����� varchar(16) FOREIGN KEY,
    Ʒ�� NVARCHAR(100),
    ��Ʒ���� NVARCHAR(100),
    �۸� DECIMAL(18, 2),
    ������� INT,
    FOREIGN KEY (Ա�����) REFERENCES employee(Ա�����)
);

CREATE TABLE employee (
    Ա����� VARCHAR(16) PRIMARY KEY,
    ���� VARCHAR(20),
    �Ա� VARCHAR(3),
    ���� VARCHAR(3),
    ���� VARCHAR(3),
    �ֻ����� VARCHAR(20),
    ��ͥסַ VARCHAR(30)
);

delete from  �˻�