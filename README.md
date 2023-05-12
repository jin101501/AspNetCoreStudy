## EntityFram work Core로 데이터 베이스 생성하는 방법(MS-SQL)

### 1. Net Core(MVC)형식의 프로젝트를 생성을 한뒤 해당되는 패키지를 다운로드한다.
- DB를 연결을 하기 위해서는 (EnttityFrameworkCore, EnttityFrameworkCore.SqlServer, EnttityFrameworkCore.Tools을 다운을 받아야한다.)

<img src=".\image\create.png" width="300">

<img src=".\image\setting1.png" width="300">

<img src=".\image\setting2.png" width="300">

### 2.설치가 완료되면 생성하고자 하는 DB에 관련된 객체의 Class을 Model폴더 아래에 생성을 한다.(예시는 게시판을 만들기 위해 생성을 했다.)
<img src=".\image\User.PNG" width="300">

<img src=".\image\Note.PNG" width="300">

### 3.DbContext을 생성을 한다.(Table생성을 하기 위한 코드를 작성을 하기 위해 생성을 한다.)
<img src=".\image\Connection.png" width="300">

### 4.View→Other Windows→PackageMangerConsole을 클릭하고 콘솔에  'Add-Migration 선언되는 클래스 이름' 을 입력하여 생성을 생성한다.
- 예시로 FirstMigration이라는 클래스를 생성을하였다.
- Add-Migration이라고 입력을 했을때 생성이 되지 않고 에러가 발생했을 경우( EnttityFrameworkCore.Tool가 설치되어 있는지 확인해야한다.)

 <img src=".\image\DB1.png" width="300">

 <img src=".\image\DB2.png" width="300">

 ### 5.정상적으로 완료되면 다음과 같이 클래스 파일 및 해당되는 테이블에 관련된 내용이 작성된다.

 <img src=".\image\complete.PNG" width="300">

 ### 6. DB의 명령어만 만들어진 상태인 상황에서 실제로 만드는 명령어를 Package Manger Console에 update-database 을 입력어를 입력을 해준다.
 - Done 이라는 문고가 나와야 정상적으로 생성이 된다. 만약 생성이 되지않고 오류가 발생이 되면 연결되는 문자열 뒤에 Encrypt=false을 추가하면 에러가 없어지고 생성이 된다.


  <img src=".\image\Create2.png" width="300">