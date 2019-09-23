# TEAM12
# INSTALL MYSQL
         Xampp or ampp or lampp or wamp (có phpmyadmin tiện quản lý) or - mysql => link search google 
         Cài 2 bản này để có thể sử dụng được mysql trên VISUAL STUDIO 
         MySQL for Visual Studio: https://dev.mysql.com/downloads/windows/visualstudio/
         MySQL Connector for Visual studio: https://dev.mysql.com/downloads/connector/net/
# CONFIG DATABASE:
file "DBUtils.cs"
# CALL MYSQL ĐỂ DÙNG:
``` MySqlConnection conn = DBUtils.GetDBConnection();```

         conn.Open(); // MỞ

          .....//CODE HERE

         conn.Close();//ĐÓNG

