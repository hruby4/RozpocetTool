# RozpocetTool
To start this programme you need:
MySQL server
Internet connection minimum 8mb/s

Step by step setup:
1. start your MySQL database server
1. import /export.sql to your MySQL database

2. set Omega/config/config.conf:    address     - db server address
                                    port        - db server address port
                                    user        - db user
                                    password    - db user password
                                    schema      - db schema name (if you didnt change the export it is "rozpocet_tool" by default)
                                    scrape_url  - dont change("https://www.pro-doma.cz")

3. start programme by "Omega.exe - Shortcut"