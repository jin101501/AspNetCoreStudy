## EntityFram work Core�� ������ ���̽� �����ϴ� ���(MS-SQL)

### 1. Net Core(MVC)������ ������Ʈ�� ������ �ѵ� �ش�Ǵ� ��Ű���� �ٿ�ε��Ѵ�.
- DB�� ������ �ϱ� ���ؼ��� (EnttityFrameworkCore, EnttityFrameworkCore.SqlServer, EnttityFrameworkCore.Tools�� �ٿ��� �޾ƾ��Ѵ�.)

<img src=".\image\create.png" width="300">

<img src=".\image\setting1.png" width="300">

<img src=".\image\setting2.png" width="300">

### 2.��ġ�� �Ϸ�Ǹ� �����ϰ��� �ϴ� DB�� ���õ� ��ü�� Class�� Model���� �Ʒ��� ������ �Ѵ�.(���ô� �Խ����� ����� ���� ������ �ߴ�.)
<img src=".\image\User.PNG" width="300">

<img src=".\image\Note.PNG" width="300">

### 3.DbContext�� ������ �Ѵ�.(Table������ �ϱ� ���� �ڵ带 �ۼ��� �ϱ� ���� ������ �Ѵ�.)
<img src=".\image\Connection.png" width="300">

### 4.View��Other Windows��PackageMangerConsole�� Ŭ���ϰ� �ֿܼ�  'Add-Migration ����Ǵ� Ŭ���� �̸�' �� �Է��Ͽ� ������ �����Ѵ�.
- ���÷� FirstMigration�̶�� Ŭ������ �������Ͽ���.
- Add-Migration�̶�� �Է��� ������ ������ ���� �ʰ� ������ �߻����� ���( EnttityFrameworkCore.Tool�� ��ġ�Ǿ� �ִ��� Ȯ���ؾ��Ѵ�.)

 <img src=".\image\DB1.png" width="300">

 <img src=".\image\DB2.png" width="300">

 ### 5.���������� �Ϸ�Ǹ� ������ ���� Ŭ���� ���� �� �ش�Ǵ� ���̺� ���õ� ������ �ۼ��ȴ�.

 <img src=".\image\complete.PNG" width="300">

 ### 6. DB�� ��ɾ ������� ������ ��Ȳ���� ������ ����� ��ɾ Package Manger Console�� update-database �� �Է¾ �Է��� ���ش�.
 - Done �̶�� ���� ���;� ���������� ������ �ȴ�. ���� ������ �����ʰ� ������ �߻��� �Ǹ� ����Ǵ� ���ڿ� �ڿ� Encrypt=false�� �߰��ϸ� ������ �������� ������ �ȴ�.


  <img src=".\image\Create2.png" width="300">