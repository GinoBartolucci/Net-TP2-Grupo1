--ESPECIALIDADES
    USE [Academia]
    GO
    INSERT INTO [dbo].[especialidades] ([desc_especialidad])
        VALUES('Ingenieria en Sistemas')
    GO
    USE [Academia]
    GO
    INSERT INTO [dbo].[especialidades] ([desc_especialidad])
        VALUES('Ingenieria Quimica')
    GO
--
--PLANES
    USE [Academia]
    GO
    INSERT INTO [dbo].[planes]([desc_plan],[id_especialidad])
        VALUES('2006', 1)
    GO
    GO
    INSERT INTO [dbo].[planes]([desc_plan],[id_especialidad])
        VALUES('2012', 1)
    GO
    USE [Academia]
    GO
    INSERT INTO [dbo].[planes]([desc_plan],[id_especialidad])
        VALUES('2006', 2)
    GO
--
--ADMINS
    insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gino', 'Bartolucci', '52 Pepper Wood Circle', 'jsawers0@typepad.com', '608-481-6421', '21.04.2021', 26495, 1, 1);
    insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Fran', 'Mendiburu', '52 Pepper Wood Circle', 'jsawers0@typepad.com', '608-481-6421', '202121-04-', 26256, 1, 1);
--
--ALUMNOS
    --ALUMNOS PLAN #1 SISTEMAS
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jackson', 'Sawers', '52 Pepper Wood Circle', 'jsawers0@typepad.com', '608-481-6421', '21.04.2021', 26495, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Leo', 'Messi', '63 Menomonie Road', 'adachs1@simplemachines.org', '318-296-8365', '27.07.1986', 66611, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Noami', 'Wallenger', '1 Eagan Place', 'nwallenger2@netscape.com', '735-987-3572', '13.01.2007', 27788, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hyacinthia', 'Cavee', '0 Elmside Parkway', 'hcavee3@google.it', '250-385-6580', '05.06.1998', 45489, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cash', 'Sworn', '50 Eliot Trail', 'csworn4@timesonline.co.uk', '478-962-8979', '15.01.2008', 56179, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Idelle', 'O''Tuohy', '5873 Golf Park', 'iotuohy5@yellowbook.com', '108-392-3411', '13.11.1982', 16838, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Valaree', 'Shiliton', '927 Tony Court', 'vshiliton6@yellowbook.com', '500-151-1580', '24.11.2020', 50838, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jorrie', 'Breslin', '379 Barnett Point', 'jbreslin7@walmart.com', '684-844-7498', '24.03.1991', 69717, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kakalina', 'Troyes', '84 Schmedeman Drive', 'ktroyes8@mediafire.com', '943-677-6326', '29.07.2008', 75439, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kessiah', 'Tidmas', '0337 Fremont Junction', 'ktidmas9@jugem.jp', '679-440-4507', '12.03.2018', 80238, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Celesta', 'Raylton', '299 Goodland Junction', 'crayltona@slate.com', '957-531-5903', '28.11.2015', 41084, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Heloise', 'Toft', '670 Sherman Hill', 'htoftb@discovery.com', '235-705-9401', '25.05.2000', 84437, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Xerxes', 'Clive', '04834 Bobwhite Circle', 'xclivec@weibo.com', '704-849-4357', '09.10.2008', 49968, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Oswell', 'Pidcock', '48214 Scoville Street', 'opidcockd@i2i.jp', '181-390-8893', '04.03.1988', 66768, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Chrissy', 'Sier', '58 Kensington Center', 'csiere@spotify.com', '474-679-3653', '09.11.1982', 98111, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Peder', 'Blethyn', '12 Hudson Alley', 'pblethynf@fc2.com', '577-109-4733', '05.04.1992', 53384, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Derk', 'Goede', '039 Bartillon Plaza', 'dgoedeg@usnews.com', '976-525-2729', '13.11.2018', 12321, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Augustina', 'Dyka', '58868 Marquette Parkway', 'adykah@infoseek.co.jp', '218-953-6537', '30.12.2002', 17123, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Renee', 'Zold', '42958 Johnson Circle', 'rzoldi@nasa.gov', '239-800-9312', '16.07.2017', 97249, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Benny', 'Kleinberer', '73 Nova Junction', 'bkleinbererj@people.com.cn', '232-488-9602', '07.08.2013', 45665, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ulrich', 'Youster', '49 Dixon Trail', 'uyousterk@seesaa.net', '534-937-9058', '26.05.1989', 20520, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Yasmin', 'Ashfield', '91907 Sutherland Crossing', 'yashfieldl@hibu.com', '758-724-0359', '13.05.1999', 43939, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Barri', 'Mitchenson', '3200 Northland Lane', 'bmitchensonm@cargocollective.com', '633-709-5576', '30.12.1983', 38020, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nat', 'Beauchop', '22 Nobel Street', 'nbeauchopn@seattletimes.com', '916-140-9081', '08.02.2007', 79391, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Art', 'Rollinson', '60 Haas Court', 'arollinsono@nba.com', '213-376-9814', '23.08.1994', 20366, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nichol', 'Lahive', '999 Vernon Terrace', 'nlahivep@is.gd', '334-549-3153', '27.09.1997', 50243, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Magda', 'Caustic', '7379 Service Center', 'mcausticq@tinypic.com', '833-569-1062', '25.10.2001', 92289, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mora', 'Denacamp', '8187 Eagan Parkway', 'mdenacampr@howstuffworks.com', '673-585-3940', '18.11.2008', 96131, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Maiga', 'Butler-Bowdon', '802 Waxwing Street', 'mbutlerbowdons@jiathis.com', '161-374-3058', '28.02.1989', 27350, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lisbeth', 'Hutcheon', '4094 Mcguire Park', 'lhutcheont@cornell.edu', '281-850-7482', '17.01.1993', 87923, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kori', 'Wetherill', '42 Garrison Place', 'kwetherillu@free.fr', '379-434-9239', '07.01.2015', 54099, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Chrysler', 'Ciccotto', '88009 Bobwhite Terrace', 'cciccottov@china.com.cn', '948-638-7899', '26.06.2014', 27881, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dallas', 'Krysztowczyk', '1482 Maywood Trail', 'dkrysztowczykw@un.org', '958-276-1724', '15.12.1983', 73593, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bartram', 'Rushe', '043 Farmco Road', 'brushex@samsung.com', '696-300-7772', '02.05.1989', 92858, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Chanda', 'Ellerby', '22 Donald Junction', 'cellerbyy@sakura.ne.jp', '127-216-1711', '04.12.1982', 19578, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Billi', 'Chateau', '609 Bellgrove Crossing', 'bchateauz@github.com', '348-779-9730', '12.07.1982', 26833, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Emlynn', 'Swaby', '147 Stoughton Circle', 'eswaby10@senate.gov', '473-332-7724', '19.08.1996', 53478, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mariam', 'Papps', '051 Merry Place', 'mpapps11@miitbeian.gov.cn', '605-447-2820', '13.02.2019', 48335, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Melesa', 'Smoughton', '4152 Esch Plaza', 'msmoughton12@scientificamerican.com', '514-850-2690', '25.03.2005', 49098, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Merrile', 'Perello', '81149 Mosinee Avenue', 'mperello13@europa.eu', '913-985-4731', '19.01.1983', 43566, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Inglis', 'Fullerlove', '425 Homewood Way', 'ifullerlove14@bbc.co.uk', '425-879-2168', '02.02.1996', 79925, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ailene', 'Beever', '3 Kennedy Center', 'abeever15@amazon.de', '764-771-2098', '19.11.1982', 13880, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Charmain', 'Whorf', '3 Pierstorff Court', 'cwhorf16@wikispaces.com', '576-829-5925', '07.04.1984', 60048, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bess', 'Nellies', '0 Esker Place', 'bnellies17@plala.or.jp', '682-695-9920', '15.09.1993', 16351, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tamarra', 'Parlour', '452 Clarendon Trail', 'tparlour18@yolasite.com', '687-822-5684', '29.12.1997', 84133, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Anthiathia', 'Capozzi', '8 Pond Point', 'acapozzi19@redcross.org', '261-541-3864', '22.08.1997', 14804, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Charisse', 'Chazette', '2 Grover Crossing', 'cchazette1a@networkadvertising.org', '670-258-7185', '02.10.2007', 79183, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ingunna', 'Yoakley', '6212 Warner Lane', 'iyoakley1b@acquirethisname.com', '185-105-5018', '02.07.1995', 56506, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Fabiano', 'Coggon', '88370 Utah Lane', 'fcoggon1c@dropbox.com', '130-761-6472', '22.11.2010', 98136, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Delaney', 'Ferier', '79950 Commercial Pass', 'dferier1d@instagram.com', '235-452-9100', '16.12.2001', 30979, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jillane', 'Pottage', '97 Magdeline Way', 'jpottage1e@psu.edu', '907-808-5479', '27.07.1988', 63825, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Doris', 'Coster', '04 Grayhawk Lane', 'dcoster1f@prnewswire.com', '298-199-8685', '26.03.2009', 46021, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Enrica', 'Francklin', '30772 Petterle Plaza', 'efrancklin1g@usda.gov', '320-393-1633', '27.01.1980', 60723, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Venita', 'Jopp', '79821 Pierstorff Center', 'vjopp1h@cpanel.net', '237-958-8741', '25.08.1989', 20120, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Blanca', 'Fortun', '251 Vahlen Crossing', 'bfortun1i@va.gov', '576-777-9628', '22.06.2020', 22322, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Marilee', 'Marusic', '0 Colorado Place', 'mmarusic1j@etsy.com', '222-749-1168', '27.05.2008', 87883, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Penrod', 'Pilsbury', '7 Morrow Court', 'ppilsbury1k@utexas.edu', '463-373-3486', '21.10.2012', 29969, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Leeland', 'Arrighini', '7 Old Gate Pass', 'larrighini1l@columbia.edu', '414-127-4114', '10.12.2007', 58315, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Coraline', 'Rogeron', '5982 Tennessee Hill', 'crogeron1m@forbes.com', '432-208-3941', '08.11.2001', 43547, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nonna', 'Gullane', '2162 Fuller Junction', 'ngullane1n@sina.com.cn', '581-686-2492', '30.05.1999', 68636, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Maisie', 'Storie', '136 Kenwood Road', 'mstorie1o@ning.com', '731-158-8621', '19.03.2011', 68688, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Penelopa', 'Latham', '7705 Cottonwood Plaza', 'platham1p@microsoft.com', '909-187-7102', '28.11.2000', 92754, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ana', 'Ivantyev', '8206 Holmberg Center', 'aivantyev1q@indiegogo.com', '138-785-2717', '23.12.2006', 60120, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Vilma', 'Stellino', '060 Cody Court', 'vstellino1r@cbslocal.com', '790-472-1302', '05.03.2010', 18312, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Isabel', 'Shortin', '1002 Valley Edge Avenue', 'ishortin1s@technorati.com', '937-843-8349', '01.04.1980', 48649, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nananne', 'Kuhne', '656 Rigney Junction', 'nkuhne1t@php.net', '751-927-3072', '27.01.2019', 79809, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kristin', 'Andretti', '62 Charing Cross Junction', 'kandretti1u@mit.edu', '139-683-6504', '03.10.1985', 33440, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Danika', 'Windaybank', '55 Sauthoff Alley', 'dwindaybank1v@liveinternet.ru', '614-769-9981', '25.07.1994', 76896, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Zenia', 'Bewlay', '1123 2nd Circle', 'zbewlay1w@indiegogo.com', '613-717-1397', '13.06.2002', 63382, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Joli', 'Davydenko', '9 Randy Road', 'jdavydenko1x@reddit.com', '553-610-5916', '25.12.1994', 38420, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Aline', 'Ajean', '1 Saint Paul Circle', 'aajean1y@mediafire.com', '554-180-4085', '16.10.1998', 79695, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Osborne', 'Durrant', '31 Towne Road', 'odurrant1z@4shared.com', '682-860-9588', '22.04.2016', 72087, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Yolanda', 'Drayson', '195 Spohn Junction', 'ydrayson20@aboutads.info', '583-171-1664', '06.08.2013', 18070, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Arabele', 'Lichfield', '41017 Westport Crossing', 'alichfield21@japanpost.jp', '505-854-6949', '25.06.2009', 76582, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Florence', 'Sunnex', '301 Norway Maple Pass', 'fsunnex22@gov.uk', '321-239-7145', '04.10.1998', 55671, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Oralia', 'Balffye', '9224 Mallard Street', 'obalffye23@baidu.com', '884-721-3612', '19.10.1984', 54761, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sissie', 'McNaught', '37 East Road', 'smcnaught24@baidu.com', '900-359-2260', '11.02.2009', 60251, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Steffi', 'Dix', '30446 Hazelcrest Junction', 'sdix25@devhub.com', '225-221-2455', '25.04.2001', 56211, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bernie', 'Llewelyn', '3 Ronald Regan Terrace', 'bllewelyn26@twitter.com', '161-549-6238', '22.08.2020', 53203, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Maurizio', 'O''Sullivan', '49 Sunbrook Circle', 'mosullivan27@ocn.ne.jp', '879-716-7406', '16.05.2019', 31420, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Birgitta', 'Eastope', '88 Main Street', 'beastope28@fastcompany.com', '810-522-6167', '12.11.1983', 93293, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Oriana', 'Zielinski', '55 Daystar Center', 'ozielinski29@deliciousdays.com', '809-446-3933', '08.01.1984', 85750, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Allix', 'Van Der Walt', '0 Jenna Circle', 'avanderwalt2a@usgs.gov', '991-198-2373', '16.10.1995', 56199, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Abbe', 'MacRorie', '735 Schlimgen Parkway', 'amacrorie2b@macromedia.com', '982-977-5666', '28.01.1989', 71546, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dayle', 'Clymo', '879 Eastwood Lane', 'dclymo2c@php.net', '569-677-0790', '15.05.1986', 68416, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Fifine', 'Crabbe', '0 American Ash Avenue', 'fcrabbe2d@cargocollective.com', '922-977-6815', '12.02.2020', 54903, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Edik', 'Allwell', '5 Little Fleur Avenue', 'eallwell2e@over-blog.com', '598-323-3473', '17.10.2020', 85218, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gerald', 'Davison', '75 Troy Trail', 'gdavison2f@icio.us', '425-318-4907', '18.03.1996', 31474, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ellie', 'Jorin', '5 Burning Wood Place', 'ejorin2g@xinhuanet.com', '525-114-8653', '28.05.1982', 62966, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Elyn', 'Seedhouse', '0 Troy Place', 'eseedhouse2h@pen.io', '502-356-2641', '13.04.2009', 47843, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ileane', 'Maisey', '2 Larry Way', 'imaisey2i@google.com.au', '885-935-0831', '05.09.2007', 50525, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cosmo', 'Blakiston', '84 Myrtle Point', 'cblakiston2j@networkadvertising.org', '162-643-9152', '05.12.1993', 58113, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Turner', 'Collaton', '1 Village Circle', 'tcollaton2k@wp.com', '256-325-1525', '15.07.2013', 77918, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Daphna', 'Elman', '27125 Gina Court', 'delman2l@artisteer.com', '947-949-0860', '22.09.2021', 33862, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Samara', 'Goldsbury', '56101 Morning Lane', 'sgoldsbury2m@cam.ac.uk', '593-839-8183', '21.04.2008', 21751, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Galina', 'Handsheart', '7 2nd Hill', 'ghandsheart2n@sbwire.com', '836-650-4444', '05.12.1999', 24723, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Elene', 'Legrand', '70464 Roth Parkway', 'elegrand2o@tuttocitta.it', '611-301-3781', '28.04.2001', 83901, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jere', 'Syne', '199 Twin Pines Trail', 'jsyne2p@google.pl', '150-240-3568', '28.09.1981', 46273, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hortensia', 'Colledge', '6 Almo Plaza', 'hcolledge2q@blogs.com', '358-900-2880', '30.07.2006', 36143, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lia', 'Aitchison', '1437 Upham Pass', 'laitchison2r@craigslist.org', '323-820-0129', '17.10.1994', 91889, 3, 1);
    --
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kendre', 'Muddle', '77007 Warrior Lane', 'kmuddle0@fema.gov', '209-140-1189', '30.06.1999', 67871, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nona', 'Jehu', '400 Blackbird Court', 'njehu1@hhs.gov', '829-433-6446', '02.04.2006', 56883, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Norbert', 'Wardley', '50987 Stuart Center', 'nwardley2@fda.gov', '312-404-7421', '28.02.2015', 52825, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Fabio', 'FitzAlan', '14 Mariners Cove Terrace', 'ffitzalan3@europa.eu', '522-424-1898', '07.09.2001', 36237, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Alvera', 'Chadband', '06 Daystar Pass', 'achadband4@blog.com', '758-761-3623', '10.05.1985', 59831, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hildegarde', 'Mundall', '80491 Luster Park', 'hmundall5@qq.com', '568-597-8871', '29.07.2020', 13955, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lacy', 'Sealey', '133 Ridge Oak Street', 'lsealey6@fotki.com', '730-726-6915', '18.02.2014', 41515, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Baxy', 'Glossup', '719 Sloan Avenue', 'bglossup7@europa.eu', '978-948-2603', '18.10.1996', 73583, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Algernon', 'Tschersich', '79193 Myrtle Hill', 'atschersich8@baidu.com', '746-383-1263', '10.10.2017', 10059, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Salmon', 'Plowman', '464 Northport Pass', 'splowman9@quantcast.com', '379-922-2758', '19.10.1997', 67596, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Liuka', 'Prandoni', '696 Claremont Hill', 'lprandonia@angelfire.com', '105-540-1707', '13.05.2016', 12008, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kirsteni', 'Cawsby', '4544 Schiller Junction', 'kcawsbyb@blog.com', '274-837-4749', '30.04.2013', 20878, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rayna', 'Dalgleish', '119 Pierstorff Avenue', 'rdalgleishc@cyberchimps.com', '238-678-1727', '18.03.2009', 44106, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gayle', 'Venny', '00 Aberg Park', 'gvennyd@smugmug.com', '256-885-5570', '05.03.2020', 97524, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Faydra', 'Iacovides', '26 Sullivan Road', 'fiacovidese@tinypic.com', '584-886-8103', '27.10.2010', 48730, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ellyn', 'Peres', '2 Dottie Terrace', 'eperesf@cbsnews.com', '270-536-4339', '26.04.1995', 56688, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Abie', 'Skeel', '232 Ludington Pass', 'askeelg@youtu.be', '477-118-0680', '26.08.1983', 58171, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Janaye', 'Whitland', '566 Stephen Junction', 'jwhitlandh@google.pl', '357-602-6932', '30.07.1982', 30239, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gail', 'Nel', '704 Orin Trail', 'gneli@fastcompany.com', '347-291-1019', '14.11.1980', 90139, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Wendell', 'Littleproud', '22 Gateway Point', 'wlittleproudj@oaic.gov.au', '416-855-3156', '20.10.1994', 88298, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dahlia', 'Schruyer', '06019 Twin Pines Road', 'dschruyerk@last.fm', '808-259-2030', '27.03.1996', 60990, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Godwin', 'Potell', '52 Hanson Trail', 'gpotelll@phpbb.com', '593-393-4384', '21.05.2015', 45916, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Augustine', 'Collumbell', '1 Bartillon Point', 'acollumbellm@soundcloud.com', '145-187-0088', '17.04.2014', 97637, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gerry', 'Erni', '41690 Cody Center', 'gernin@patch.com', '486-617-7893', '02.10.1990', 22308, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mara', 'Bacchus', '3374 Kensington Lane', 'mbacchuso@uol.com.br', '432-329-6450', '26.08.2001', 56687, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jania', 'Hayer', '08 Longview Street', 'jhayerp@dagondesign.com', '779-287-3181', '19.10.2018', 56300, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Blondell', 'Bills', '0524 Dixon Plaza', 'bbillsq@google.ru', '450-904-9634', '23.05.1982', 91289, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cody', 'House', '7 Randy Parkway', 'chouser@oracle.com', '649-247-4165', '02.10.1992', 88607, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nicoli', 'Soans', '58949 Carberry Hill', 'nsoanss@china.com.cn', '796-867-5894', '29.11.1987', 33778, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Miner', 'Broadey', '794 Debs Way', 'mbroadeyt@tmall.com', '487-615-6656', '18.07.2010', 33132, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Perceval', 'Naismith', '7137 Kensington Alley', 'pnaismithu@squarespace.com', '985-358-5391', '22.09.1993', 65050, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Codi', 'Pratt', '4938 Myrtle Pass', 'cprattv@businessinsider.com', '140-339-6413', '05.11.1986', 69538, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Pryce', 'Nayshe', '99 Texas Pass', 'pnayshew@jalbum.net', '540-572-2107', '25.06.2017', 39341, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Manuel', 'Propper', '39068 Veith Way', 'mpropperx@wired.com', '726-387-0844', '25.05.1985', 66110, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sandi', 'Jeune', '55 Reindahl Terrace', 'sjeuney@boston.com', '524-765-1541', '08.04.1995', 53943, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Farica', 'Farfull', '96930 Clyde Gallagher Road', 'ffarfullz@newyorker.com', '251-148-5357', '04.01.1995', 52023, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dacia', 'Lago', '3228 Ronald Regan Point', 'dlago10@accuweather.com', '691-250-6831', '07.02.1985', 11489, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nicoline', 'Joscelin', '4881 Kenwood Plaza', 'njoscelin11@zimbio.com', '107-874-7155', '04.04.2013', 28416, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tierney', 'Khidr', '3916 Monument Center', 'tkhidr12@ovh.net', '579-576-9306', '19.04.1987', 63619, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hynda', 'Bretelle', '122 Vidon Street', 'hbretelle13@cafepress.com', '187-312-2093', '25.04.1980', 56605, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Abraham', 'Marte', '8 Namekagon Crossing', 'amarte14@e-recht24.de', '265-570-9857', '30.11.2016', 85039, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Barrie', 'Meeny', '29 Kennedy Point', 'bmeeny15@si.edu', '735-936-7302', '29.09.2019', 74794, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sawyere', 'Brolechan', '515 Oneill Center', 'sbrolechan16@google.ru', '289-681-2584', '08.08.1999', 39265, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Trixie', 'McMenemy', '285 Erie Center', 'tmcmenemy17@gravatar.com', '845-943-3466', '17.11.1992', 37609, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gerry', 'Pippard', '11491 Sycamore Parkway', 'gpippard18@wikimedia.org', '853-637-0905', '29.11.2004', 60624, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ermanno', 'Westcarr', '4160 Kensington Park', 'ewestcarr19@microsoft.com', '721-310-0813', '30.12.1995', 92931, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bar', 'Carek', '1848 5th Plaza', 'bcarek1a@examiner.com', '133-840-7551', '11.11.1999', 90969, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Marje', 'Owbrick', '0 Grasskamp Center', 'mowbrick1b@wiley.com', '452-377-7825', '24.02.2020', 74859, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Vincents', 'Mockett', '190 Oriole Lane', 'vmockett1c@google.it', '292-254-6502', '02.12.1996', 90851, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ethan', 'Fairfull', '34 Erie Terrace', 'efairfull1d@who.int', '391-793-2140', '22.04.1982', 50250, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Conrado', 'Fazan', '1461 Sutherland Hill', 'cfazan1e@arstechnica.com', '178-876-3540', '24.03.2017', 56908, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Keslie', 'Casolla', '62727 Prairieview Circle', 'kcasolla1f@instagram.com', '332-482-5600', '06.11.1992', 29908, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ricardo', 'Webber', '76748 Lukken Road', 'rwebber1g@seesaa.net', '373-222-9625', '11.01.2012', 91137, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Thatcher', 'Roantree', '47841 Carioca Alley', 'troantree1h@wikia.com', '550-595-0221', '28.10.2012', 93333, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Georgine', 'Darrow', '54172 Portage Center', 'gdarrow1i@stanford.edu', '323-744-7840', '12.08.1989', 24268, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lona', 'Leggen', '6488 Alpine Pass', 'lleggen1j@arstechnica.com', '527-728-7439', '02.10.2019', 65420, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Abigael', 'Stilldale', '025 Schurz Way', 'astilldale1k@who.int', '193-936-0110', '09.05.2013', 73967, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hastie', 'Delcastel', '8864 Loftsgordon Street', 'hdelcastel1l@stanford.edu', '725-154-9099', '23.12.2006', 42075, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Vance', 'Venable', '04 Comanche Drive', 'vvenable1m@cpanel.net', '376-838-8361', '24.09.2018', 31390, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Corabel', 'Symper', '591 Fordem Place', 'csymper1n@wikispaces.com', '133-961-1122', '11.02.2000', 61641, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dorie', 'Merrington', '90887 Hagan Lane', 'dmerrington1o@blinklist.com', '849-657-7107', '19.01.1998', 94816, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Carolyne', 'Hebson', '097 Moose Hill', 'chebson1p@hhs.gov', '735-423-8194', '20.10.2017', 39973, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kettie', 'Blankhorn', '15476 Coleman Crossing', 'kblankhorn1q@sbwire.com', '815-685-8554', '02.05.2016', 59154, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Abbott', 'McPaike', '8954 Crownhardt Court', 'amcpaike1r@nature.com', '600-348-0446', '15.01.2009', 71996, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tadio', 'Ferreira', '2 Dawn Parkway', 'tferreira1s@wired.com', '735-471-8037', '02.12.1981', 84160, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tad', 'Sjollema', '179 Old Gate Plaza', 'tsjollema1t@issuu.com', '888-444-0919', '18.01.2002', 94238, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Pablo', 'Dowber', '32 4th Terrace', 'pdowber1u@theglobeandmail.com', '248-475-8840', '04.10.1999', 44748, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dale', 'Gardner', '3 Upham Pass', 'dgardner1v@amazon.co.jp', '839-525-1757', '05.08.2017', 20799, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kath', 'Philbrick', '7 Thierer Pass', 'kphilbrick1w@chronoengine.com', '181-478-4001', '26.03.1988', 90076, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kain', 'Scoggin', '595 Rowland Road', 'kscoggin1x@joomla.org', '772-327-7646', '31.03.1988', 92310, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Beatrix', 'Hanna', '897 Karstens Place', 'bhanna1y@wired.com', '789-289-7087', '16.04.1997', 26231, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Constancy', 'Kleinsmuntz', '8 Gerald Park', 'ckleinsmuntz1z@ucoz.ru', '217-635-2985', '29.02.1992', 30228, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sondra', 'Teulier', '862 Debs Plaza', 'steulier20@cocolog-nifty.com', '421-883-6474', '01.02.2000', 66638, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lorilee', 'Inker', '1655 Ronald Regan Lane', 'linker21@bbb.org', '156-744-2786', '20.10.1999', 59437, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Alecia', 'Skelcher', '185 Pawling Park', 'askelcher22@alibaba.com', '523-632-3805', '20.03.1985', 13517, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rusty', 'Francey', '960 Waubesa Park', 'rfrancey23@cargocollective.com', '278-488-4984', '26.05.1986', 48678, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hilda', 'Domone', '9123 Moulton Park', 'hdomone24@hud.gov', '575-880-8938', '07.06.1980', 78359, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Miquela', 'Stieger', '387 Portage Point', 'mstieger25@home.pl', '414-338-5210', '07.07.2009', 89997, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gui', 'Kinlock', '88712 Grayhawk Park', 'gkinlock26@mapquest.com', '310-742-3980', '13.10.2017', 26794, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Meredeth', 'Planke', '90510 Londonderry Parkway', 'mplanke27@scribd.com', '383-200-0449', '10.03.2019', 10504, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Buddy', 'Brownell', '41 Steensland Pass', 'bbrownell28@facebook.com', '359-428-9519', '15.02.2018', 35217, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Burtie', 'Stebbings', '44 Spohn Avenue', 'bstebbings29@mashable.com', '546-268-7305', '13.05.2013', 75954, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Fremont', 'Thaim', '4396 Ohio Avenue', 'fthaim2a@tuttocitta.it', '359-385-1863', '08.04.2001', 83972, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Daffie', 'Crosi', '738 John Wall Circle', 'dcrosi2b@newyorker.com', '615-213-9440', '29.02.2004', 80882, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bethanne', 'Ockland', '38 Northfield Trail', 'bockland2c@ehow.com', '468-907-5917', '26.11.2011', 80150, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Katee', 'De Mattia', '8723 Warbler Crossing', 'kdemattia2d@nasa.gov', '753-936-4438', '18.03.1986', 87046, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Quinlan', 'Presman', '15 Goodland Terrace', 'qpresman2e@chicagotribune.com', '953-256-1915', '15.01.1993', 46012, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Curran', 'Brumble', '4 Crownhardt Court', 'cbrumble2f@live.com', '585-426-4041', '21.07.1982', 52157, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jacques', 'Bloan', '26 Havey Pass', 'jbloan2g@hugedomains.com', '203-323-5120', '19.02.2016', 84120, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Floris', 'Stirland', '588 Bluejay Drive', 'fstirland2h@loc.gov', '900-257-2890', '23.12.1988', 78315, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Anderson', 'Southerell', '420 Pepper Wood Avenue', 'asoutherell2i@mysql.com', '474-176-5192', '23.11.2021', 61343, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ogden', 'Liddell', '0 Morning Drive', 'oliddell2j@twitter.com', '302-675-6546', '19.02.1987', 45370, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jorge', 'Lodewick', '5989 Fieldstone Drive', 'jlodewick2k@gnu.org', '384-288-4309', '01.06.2000', 73262, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Erroll', 'Excell', '42387 Delaware Place', 'eexcell2l@whitehouse.gov', '160-228-6565', '22.06.1994', 94675, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Troy', 'Whittock', '42 Ramsey Circle', 'twhittock2m@ning.com', '242-120-9308', '02.07.1984', 23099, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Niall', 'Caswill', '84 Cascade Avenue', 'ncaswill2n@example.com', '143-803-2356', '09.12.2006', 70138, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hyacinth', 'Gregoriou', '15786 Carey Road', 'hgregoriou2o@cyberchimps.com', '975-769-2120', '17.05.1994', 82480, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Abbe', 'Pizzie', '0637 Eagan Junction', 'apizzie2p@github.io', '904-359-4357', '31.12.1991', 75381, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Chantalle', 'Albrooke', '1 Brickson Park Plaza', 'calbrooke2q@networksolutions.com', '693-946-6630', '07.04.2007', 54889, 3, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Serena', 'Fillon', '5298 Red Cloud Way', 'sfillon2r@irs.gov', '808-660-5567', '03.11.1997', 21322, 3, 1);

    --ALUMNOS PLAN #2 SISTEMAS
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rourke', 'McLaine', '52 Eagan Avenue', 'rmclaine0@nasa.gov', '507-798-5288', '08.07.1990', 70266,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Michele', 'Penrose', '10279 Judy Pass', 'mpenrose1@friendfeed.com', '219-376-7787', '14.04.2018', 25918,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Durant', 'Bayliss', '6751 Reinke Circle', 'dbayliss2@cbc.ca', '416-386-0352', '04.12.2004', 22962,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Aldric', 'Braker', '8 Roxbury Avenue', 'abraker3@mapy.cz', '456-374-2504', '15.02.2000', 92036,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Brande', 'Wraith', '8 Comanche Point', 'bwraith4@hao123.com', '889-753-6047', '25.12.1995', 75651,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Reade', 'Gewer', '2 Bashford Lane', 'rgewer5@techcrunch.com', '414-308-3598', '20.12.2003', 93684,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Herbert', 'Hannan', '2 East Place', 'hhannan6@telegraph.co.uk', '494-188-8875', '01.09.2003', 55661,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Erhard', 'Elloy', '24 Kennedy Junction', 'eelloy7@vkontakte.ru', '389-637-5963', '14.08.2010', 78214,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Clovis', 'Cleator', '5 Commercial Lane', 'ccleator8@cbc.ca', '582-392-8080', '27.01.1983', 61457,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Monica', 'Jelf', '78814 John Wall Way', 'mjelf9@kickstarter.com', '349-601-9424', '12.09.2016', 87182,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Maia', 'Newlove', '1 Jay Alley', 'mnewlovea@buzzfeed.com', '344-433-3028', '29.10.2012', 33441,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Renault', 'Crother', '26738 Dakota Hill', 'rcrotherb@mapy.cz', '411-283-5609', '09.08.1995', 18867,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Quill', 'Gianulli', '98127 Caliangt Hill', 'qgianullic@bloglines.com', '635-265-5020', '01.06.2012', 70173,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Frederique', 'Pocock', '6 Michigan Alley', 'fpocockd@tinypic.com', '815-410-3217', '07.01.2002', 50272,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Binnie', 'Avramovsky', '48 Rigney Alley', 'bavramovskye@nsw.gov.au', '350-730-1951', '09.11.2001', 13439,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Devina', 'Alyukin', '1 Glendale Point', 'dalyukinf@cpanel.net', '141-270-7137', '15.06.1990', 47028,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Chantalle', 'Matyushonok', '3 Loomis Lane', 'cmatyushonokg@statcounter.com', '545-688-6692', '08.08.1982', 73652,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Erminie', 'Powis', '30 Southridge Pass', 'epowish@cargocollective.com', '547-808-5788', '08.10.2021', 50258,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cordey', 'Manvelle', '567 Burning Wood Point', 'cmanvellei@dion.ne.jp', '413-762-9501', '09.12.2003', 78115,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Leo', 'Emberson', '22 Welch Alley', 'lembersonj@nps.gov', '152-601-5101', '24.05.1989', 23796,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Marijo', 'Veschambes', '4 Bultman Way', 'mveschambesk@yelp.com', '241-554-6220', '11.06.2012', 79969,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Benoit', 'Kinker', '4 Mariners Cove Court', 'bkinkerl@comsenz.com', '997-808-5334', '15.04.2013', 57604,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Merilee', 'Tamlett', '50 Blue Bill Park Center', 'mtamlettm@lulu.com', '550-613-5727', '12.03.1984', 22934,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ingeberg', 'Eates', '3 Service Road', 'ieatesn@techcrunch.com', '400-743-9530', '15.09.2011', 77330,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Shermie', 'Ommundsen', '1 Bashford Place', 'sommundseno@ifeng.com', '854-302-5837', '12.01.2007', 35123,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Christian', 'Di Bartolomeo', '85628 Emmet Place', 'cdibartolomeop@google.com.br', '339-943-9907', '23.09.2015', 23792,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nathanael', 'Kubal', '740 Brickson Park Road', 'nkubalq@reverbnation.com', '944-657-1400', '22.12.2001', 29833,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jeffie', 'Gallemore', '7633 Farwell Avenue', 'jgallemorer@mac.com', '668-408-2034', '24.01.2011', 10176,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jaquenetta', 'Ledson', '6 Marcy Parkway', 'jledsons@nbcnews.com', '682-810-9845', '03.05.1998', 25066,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Denni', 'Merrikin', '5443 Division Way', 'dmerrikint@hp.com', '732-543-0926', '18.06.2019', 33766,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Shandy', 'Marcus', '0 Vera Circle', 'smarcusu@istockphoto.com', '929-342-1419', '24.06.1982', 90531,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Siusan', 'Garraway', '3 Killdeer Way', 'sgarrawayv@ca.gov', '430-207-5134', '21.11.1998', 80726,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nancey', 'Caret', '2 Coleman Place', 'ncaretw@jiathis.com', '172-161-2246', '23.12.1992', 38515,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Homer', 'Acuna', '69 Namekagon Center', 'hacunax@tiny.cc', '407-165-7694', '08.04.1986', 82655,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gabi', 'Danihelka', '396 Kipling Road', 'gdanihelkay@accuweather.com', '790-559-0778', '19.05.2000', 68796,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Robbert', 'Goggen', '6831 Erie Place', 'rgoggenz@mediafire.com', '794-179-7955', '22.06.1984', 46214,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Patricio', 'Naldrett', '38 Mallard Crossing', 'pnaldrett10@sitemeter.com', '704-814-4777', '10.10.1987', 76731,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Chase', 'Banfield', '2009 Esch Parkway', 'cbanfield11@soup.io', '394-408-0101', '07.08.1992', 21655,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mordecai', 'Curran', '159 Manley Trail', 'mcurran12@google.de', '140-118-7673', '22.12.2007', 97215,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gran', 'Lightwing', '90 Mifflin Circle', 'glightwing13@statcounter.com', '617-540-7574', '16.01.2006', 43580,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dorrie', 'Hatrey', '5 Barby Center', 'dhatrey14@issuu.com', '167-660-2541', '26.12.1984', 26639,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hunfredo', 'Sibthorpe', '2 Melrose Place', 'hsibthorpe15@nasa.gov', '207-839-6261', '10.09.1986', 63147,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Barry', 'Warry', '3 Wayridge Place', 'bwarry16@fastcompany.com', '350-646-5630', '29.04.1993', 43728,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dorolice', 'Tramel', '0865 Hermina Alley', 'dtramel17@japanpost.jp', '118-103-6746', '07.07.1994', 74003,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Calv', 'Kuller', '31 Fisk Parkway', 'ckuller18@weebly.com', '201-354-8690', '24.07.1993', 89596,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Franz', 'Grimsdell', '35 Muir Place', 'fgrimsdell19@slate.com', '227-166-7791', '24.07.1986', 14313,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Reuven', 'Bosma', '57571 Hoard Court', 'rbosma1a@geocities.com', '212-817-1937', '16.10.1980', 52203,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ramsay', 'Gozzard', '414 Del Sol Road', 'rgozzard1b@mapy.cz', '641-498-2714', '14.02.1991', 59399,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kinna', 'Figiovanni', '427 Toban Point', 'kfigiovanni1c@about.com', '714-458-6174', '27.12.2008', 45149,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lorilee', 'Yankishin', '1 Thompson Alley', 'lyankishin1d@a8.net', '334-640-8819', '29.08.2006', 76753,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Susie', 'Jouaneton', '6 Goodland Street', 'sjouaneton1e@cbc.ca', '752-136-1974', '25.04.1986', 12998,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Audre', 'Canelas', '88 Nevada Terrace', 'acanelas1f@indiatimes.com', '401-782-6600', '15.07.1993', 73852,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Loy', 'Mapplebeck', '19507 Sheridan Way', 'lmapplebeck1g@altervista.org', '239-520-0538', '19.07.1991', 11409,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Anson', 'O''Fallowne', '065 Jenna Point', 'aofallowne1h@nbcnews.com', '115-391-7478', '05.07.1992', 59238,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Wyatan', 'Romain', '72902 Carpenter Lane', 'wromain1i@pbs.org', '156-947-1600', '14.07.1999', 49138,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bond', 'Honywill', '412 Loeprich Circle', 'bhonywill1j@theglobeandmail.com', '763-122-8720', '29.09.2005', 15611,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Archaimbaud', 'Powland', '58184 Eastwood Court', 'apowland1k@shareasale.com', '745-206-8925', '12.05.2000', 15534,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bruno', 'Ekell', '21321 Vera Trail', 'bekell1l@sciencedirect.com', '868-413-5667', '11.06.1986', 13128,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lucais', 'Benezeit', '88669 Springs Avenue', 'lbenezeit1m@pen.io', '212-741-1809', '07.03.1998', 22269,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Beret', 'Meakin', '55 American Ash Trail', 'bmeakin1n@elegantthemes.com', '755-311-4087', '28.03.2009', 53867,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Timi', 'Klimpt', '791 Northview Hill', 'tklimpt1o@reverbnation.com', '723-980-4326', '01.11.2020', 28136,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Reeba', 'Hackney', '7294 Manley Parkway', 'rhackney1p@un.org', '873-151-4114', '04.12.2015', 47280,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Athene', 'Gascoyen', '92 Bay Circle', 'agascoyen1q@prnewswire.com', '214-933-4232', '27.07.1996', 26076,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nat', 'Hulance', '461 Ridgeview Hill', 'nhulance1r@sciencedirect.com', '686-835-8522', '19.02.2009', 12315,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Arvy', 'Rickaert', '959 Mitchell Terrace', 'arickaert1s@wsj.com', '322-428-1755', '14.03.2021', 90399,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Krystle', 'Joubert', '72627 Fulton Place', 'kjoubert1t@sogou.com', '928-818-5258', '15.09.1983', 99249,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Wyndham', 'Bachshell', '0970 Blaine Parkway', 'wbachshell1u@nba.com', '953-596-9967', '22.05.2012', 91488,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Earlie', 'Prewer', '9 Buell Parkway', 'eprewer1v@technorati.com', '882-936-0945', '14.10.1984', 97130,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Filippo', 'Josskoviz', '53110 Rockefeller Plaza', 'fjosskoviz1w@php.net', '419-760-8827', '24.02.2021', 12504,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Blair', 'Lindbergh', '91 Banding Drive', 'blindbergh1x@wisc.edu', '616-245-9285', '15.04.2015', 28313,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cyrillus', 'Wint', '7 Lakewood Terrace', 'cwint1y@networkadvertising.org', '483-807-2300', '01.03.2009', 63456,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Engracia', 'Hawkshaw', '266 Norway Maple Drive', 'ehawkshaw1z@ycombinator.com', '846-608-1058', '01.10.2020', 31227,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bev', 'Bonifacio', '019 Maple Wood Terrace', 'bbonifacio20@netscape.com', '404-265-2339', '10.01.1998', 67002,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rena', 'Cregan', '41 Monument Drive', 'rcregan21@webnode.com', '705-184-0308', '10.03.1983', 71981,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jarrod', 'Cantos', '0798 Northridge Circle', 'jcantos22@deliciousdays.com', '979-307-0174', '03.06.1994', 36649,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Albrecht', 'Presnell', '8720 Hermina Center', 'apresnell23@npr.org', '538-551-3886', '12.01.2008', 93661,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tedra', 'Beacon', '07743 Dorton Place', 'tbeacon24@umn.edu', '372-958-5488', '08.08.1988', 94906,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Leonidas', 'Carpenter', '4783 Glacier Hill Pass', 'lcarpenter25@hud.gov', '857-186-8340', '09.04.2011', 92734,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Iolande', 'Garmans', '4 Delladonna Pass', 'igarmans26@wikispaces.com', '904-389-8031', '29.04.2020', 18364,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Coralyn', 'Scowcraft', '803 Weeping Birch Pass', 'cscowcraft27@spiegel.de', '643-497-6174', '01.10.2020', 17914,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mateo', 'Blanche', '9644 Grim Pass', 'mblanche28@paypal.com', '385-777-5248', '28.01.1998', 53833,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kandace', 'Pengilly', '917 Lindbergh Street', 'kpengilly29@reference.com', '869-750-4414', '15.07.1988', 11816,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Edi', 'Arp', '06225 Debra Trail', 'earp2a@scribd.com', '565-625-0025', '01.11.2000', 40562,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kinsley', 'Ellissen', '44140 5th Terrace', 'kellissen2b@samsung.com', '427-220-4023', '24.08.2000', 91441,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ninnette', 'Wassung', '37 Clove Parkway', 'nwassung2c@sourceforge.net', '836-373-9172', '13.05.2000', 42599,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Webb', 'Clemmey', '6660 Monument Terrace', 'wclemmey2d@symantec.com', '390-641-0113', '09.02.2005', 73963,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Stearne', 'Yonge', '885 Dorton Street', 'syonge2e@1und1.de', '154-849-5914', '23.06.1985', 93986,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sigrid', 'McMurdo', '55567 Maryland Drive', 'smcmurdo2f@psu.edu', '260-545-6301', '20.12.2007', 75530,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Antone', 'Harmon', '85479 Garrison Way', 'aharmon2g@tuttocitta.it', '852-412-6927', '24.11.2015', 37752,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jenilee', 'Poile', '24646 Declaration Avenue', 'jpoile2h@boston.com', '673-841-4816', '18.08.1989', 40686,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Emmeline', 'Conisbee', '3 Starling Terrace', 'econisbee2i@weebly.com', '612-161-0708', '29.10.1997', 66515,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Clari', 'Downe', '7 Veith Park', 'cdowne2j@wikipedia.org', '392-736-4090', '07.06.1996', 29585,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Grata', 'Meineck', '12 Northfield Pass', 'gmeineck2k@51.la', '568-292-6177', '09.02.2000', 12248,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rivi', 'Ewings', '15410 Dottie Street', 'rewings2l@joomla.org', '127-530-7247', '22.01.2019', 77255,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mirabella', 'Shalloo', '4 Superior Park', 'mshalloo2m@usda.gov', '860-230-0101', '03.10.1980', 59293,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Elton', 'Curbishley', '9933 Farmco Parkway', 'ecurbishley2n@ebay.co.uk', '916-379-6092', '22.06.1991', 74124,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Denys', 'Evennett', '75418 Heath Place', 'devennett2o@mediafire.com', '743-325-8535', '23.04.1983', 19877,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kort', 'Dreamer', '27 Tony Park', 'kdreamer2p@wix.com', '703-102-4451', '10.10.1997', 98128,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Catherina', 'MacAskill', '546 Mifflin Terrace', 'cmacaskill2q@odnoklassniki.ru', '406-514-2585', '11.05.2010', 79990,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Crin', 'MacAleese', '22866 Eastlawn Lane', 'cmacaleese2r@indiegogo.com', '272-694-1568', '30.08.2004', 67621,3, 2);
    --
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Brandyn', 'Sayburn', '04387 Linden Street', 'bsayburn0@nsw.gov.au', '762-962-8728', '03.12.2005', 95098,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Flynn', 'Bridgstock', '954 Emmet Road', 'fbridgstock1@accuweather.com', '568-688-9011', '16.02.1995', 95298,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Vanessa', 'Elgie', '05 Monument Alley', 'velgie2@chron.com', '243-171-1800', '11.08.2015', 83757,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Natty', 'Nayshe', '4 Harbort Parkway', 'nnayshe3@ucoz.com', '512-489-4156', '19.01.1997', 69022,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Haleigh', 'Surmon', '03262 Little Fleur Drive', 'hsurmon4@list-manage.com', '953-464-2523', '15.09.2018', 90643,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Minette', 'Grundwater', '5845 Crownhardt Park', 'mgrundwater5@wufoo.com', '781-899-8961', '16.03.1996', 39226,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hynda', 'Loody', '56752 Washington Pass', 'hloody6@cafepress.com', '511-568-1311', '18.03.1991', 59879,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Carita', 'Tuson', '83276 Manufacturers Lane', 'ctuson7@hao123.com', '682-691-7117', '21.09.2014', 40774,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Wes', 'Bly', '09 Manitowish Point', 'wbly8@ebay.com', '574-473-5242', '28.05.1997', 84662,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nataniel', 'Mizen', '550 Namekagon Street', 'nmizen9@blogs.com', '661-950-1775', '15.01.1992', 41468,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Garnet', 'Adshed', '1 Superior Street', 'gadsheda@miitbeian.gov.cn', '723-902-2532', '08.01.1996', 23183,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Robinet', 'Coate', '70 Carpenter Place', 'rcoateb@buzzfeed.com', '884-215-6298', '26.06.1981', 35220,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ronna', 'Castro', '7397 Mallard Hill', 'rcastroc@last.fm', '217-747-4134', '24.09.1995', 20549,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Early', 'Oakey', '10 Mariners Cove Lane', 'eoakeyd@squidoo.com', '261-215-4476', '23.11.2017', 56343,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Oralie', 'Maitland', '579 Golf Alley', 'omaitlande@dot.gov', '677-288-3013', '28.09.2011', 41316,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rand', 'Aubery', '2746 Elka Circle', 'rauberyf@weebly.com', '852-266-5100', '11.06.1987', 68576,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Pavia', 'Sacase', '327 Jenna Avenue', 'psacaseg@zdnet.com', '335-590-0046', '25.04.1998', 83507,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gannie', 'Brennenstuhl', '043 Florence Center', 'gbrennenstuhlh@bloglovin.com', '135-221-2715', '05.12.2015', 13452,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nigel', 'Tindall', '4247 Monterey Park', 'ntindalli@hubpages.com', '306-652-5375', '10.03.1996', 48482,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jenine', 'Glanfield', '859 Pearson Place', 'jglanfieldj@a8.net', '994-754-4157', '29.01.1992', 35186,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Barri', 'Tomkinson', '61 Bartillon Parkway', 'btomkinsonk@github.io', '447-679-7319', '06.04.1998', 68447,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Alonzo', 'Furney', '17015 Utah Point', 'afurneyl@list-manage.com', '737-798-5829', '05.12.1995', 14300,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Merill', 'Chainey', '0681 Pennsylvania Drive', 'mchaineym@qq.com', '578-590-1116', '10.09.2012', 76948,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Winnifred', 'Garfoot', '9 Mayer Junction', 'wgarfootn@cargocollective.com', '763-347-8533', '30.06.2018', 78458,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Vasili', 'Dufer', '6 Vidon Point', 'vdufero@usatoday.com', '211-341-2078', '14.09.2017', 58907,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Normand', 'Gillon', '07297 Nobel Avenue', 'ngillonp@hao123.com', '118-607-5186', '20.05.1980', 86547,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Benedikta', 'Norris', '8121 Oakridge Alley', 'bnorrisq@altervista.org', '690-502-7732', '15.07.1994', 78290,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Shandra', 'Chiles', '35539 Fairview Parkway', 'schilesr@wp.com', '256-767-6819', '11.01.2010', 88345,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Maryjo', 'Wakefield', '4056 Messerschmidt Trail', 'mwakefields@businesswire.com', '267-999-0114', '30.05.2014', 48049,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Wilburt', 'Patman', '63630 Corben Circle', 'wpatmant@oakley.com', '434-555-6177', '27.12.1983', 59045,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kendre', 'Eagger', '570 Kensington Lane', 'keaggeru@twitter.com', '692-269-3457', '16.06.2005', 78587,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hamil', 'Roskam', '53845 Homewood Hill', 'hroskamv@illinois.edu', '671-938-2288', '03.09.1996', 32624,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Milissent', 'Yonge', '6 Jenna Road', 'myongew@huffingtonpost.com', '844-585-3640', '08.04.1982', 51484,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Elmore', 'Matyushonok', '41576 Tomscot Hill', 'ematyushonokx@feedburner.com', '777-780-5347', '09.09.2014', 32658,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Marylee', 'Danielsen', '837 Londonderry Circle', 'mdanielseny@webeden.co.uk', '810-887-6249', '16.10.2021', 48573,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Pennie', 'Spenley', '4209 Ryan Plaza', 'pspenleyz@usda.gov', '606-574-1043', '20.07.1990', 55678,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dov', 'Rohmer', '224 Emmet Road', 'drohmer10@addtoany.com', '403-373-8666', '15.12.1997', 70885,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Farleigh', 'Kubica', '887 Evergreen Terrace', 'fkubica11@bravesites.com', '885-322-6687', '03.08.1999', 70894,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Joelle', 'Southby', '866 Superior Hill', 'jsouthby12@cornell.edu', '234-150-4429', '25.03.1985', 38375,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Megen', 'Earley', '11119 Grayhawk Circle', 'mearley13@answers.com', '613-197-1796', '14.03.1988', 13393,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Eva', 'Rimes', '9 Mifflin Street', 'erimes14@csmonitor.com', '767-580-7962', '25.09.2007', 20535,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Orly', 'Camilleri', '728 Oak Drive', 'ocamilleri15@answers.com', '980-717-0839', '16.05.1993', 84899,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Julianne', 'Harrisson', '95 American Ash Place', 'jharrisson16@about.com', '237-201-6172', '01.12.2021', 88605,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ahmad', 'Merrall', '92 Kropf Street', 'amerrall17@hostgator.com', '220-848-0744', '23.09.1997', 51984,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sheffy', 'Trusler', '0942 Merchant Way', 'strusler18@is.gd', '859-208-5819', '13.05.2018', 40346,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Vallie', 'Tart', '80 Iowa Trail', 'vtart19@freewebs.com', '277-390-0933', '20.03.1985', 11948,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Oralla', 'Esbrook', '790 Stoughton Center', 'oesbrook1a@nationalgeographic.com', '530-754-0687', '10.04.1984', 91601,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Trever', 'Berrane', '656 Swallow Trail', 'tberrane1b@statcounter.com', '967-594-7820', '02.07.2003', 57231,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ginger', 'L''Homme', '5 Oriole Junction', 'glhomme1c@dot.gov', '961-141-7449', '17.01.1997', 62611,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rich', 'Jimmison', '88379 Gulseth Lane', 'rjimmison1d@ft.com', '834-969-5732', '29.04.2013', 56171,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Shepard', 'Ridwood', '4475 Hanson Lane', 'sridwood1e@zimbio.com', '767-776-4578', '22.06.2001', 69745,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kristal', 'Warlowe', '191 Sheridan Way', 'kwarlowe1f@diigo.com', '782-393-3413', '27.05.1984', 62820,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rora', 'Stiell', '74 Buena Vista Parkway', 'rstiell1g@about.me', '435-867-9112', '11.12.2004', 94369,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Wat', 'Morriss', '2447 Boyd Circle', 'wmorriss1h@cyberchimps.com', '100-415-9113', '12.02.1990', 89924,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ewell', 'Sueter', '9168 Mifflin Avenue', 'esueter1i@amazon.co.uk', '669-694-8697', '09.11.1996', 12072,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Blane', 'Blunt', '2 Thierer Pass', 'bblunt1j@deviantart.com', '799-988-6768', '06.09.2013', 36747,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Blakeley', 'Preddy', '201 Sachs Alley', 'bpreddy1k@reference.com', '625-790-4367', '28.01.2008', 55446,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Merrill', 'Ruddiforth', '57 Westend Hill', 'mruddiforth1l@reddit.com', '353-575-2879', '22.08.1996', 82382,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Georgi', 'Palomba', '4 Nevada Lane', 'gpalomba1m@plala.or.jp', '853-130-2556', '18.09.2017', 41769,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lorrie', 'Kippax', '6961 Tennyson Hill', 'lkippax1n@flavors.me', '301-124-4052', '23.04.2008', 99243,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Marlene', 'Oldroyde', '1212 Superior Trail', 'moldroyde1o@netscape.com', '760-705-7869', '26.07.2018', 78753,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jacquelynn', 'Wattingham', '38 La Follette Way', 'jwattingham1p@jalbum.net', '160-343-0440', '06.09.1982', 20139,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Seymour', 'Coils', '62986 Ilene Center', 'scoils1q@samsung.com', '343-403-9450', '24.08.2011', 62135,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Fidel', 'Physick', '139 Bayside Avenue', 'fphysick1r@merriam-webster.com', '707-330-4113', '15.05.1988', 83015,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Yorke', 'Bowshire', '9 School Terrace', 'ybowshire1s@mysql.com', '305-565-0752', '17.01.2002', 76453,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rori', 'Artharg', '0 Farwell Junction', 'rartharg1t@hugedomains.com', '634-354-2973', '15.05.2018', 67729,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tilda', 'Geockle', '24 New Castle Parkway', 'tgeockle1u@slideshare.net', '916-840-2635', '30.09.1980', 22251,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Annmarie', 'Mordan', '589 Canary Road', 'amordan1v@amazon.com', '783-620-4681', '27.02.2010', 37476,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Conchita', 'Atthow', '397 Fremont Street', 'catthow1w@woothemes.com', '310-346-7485', '02.04.2000', 47751,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Drusilla', 'O''Shavlan', '31 Shelley Place', 'doshavlan1x@github.io', '397-411-2869', '10.02.2008', 75149,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kerianne', 'Peegrem', '094 Helena Pass', 'kpeegrem1y@weibo.com', '304-894-2526', '07.10.2008', 15739,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dianna', 'Galley', '0 Fairview Point', 'dgalley1z@wordpress.com', '214-520-6671', '05.04.1985', 28736,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Skipp', 'Culver', '22959 Park Meadow Point', 'sculver20@nationalgeographic.com', '602-703-8683', '07.11.2005', 34130,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Carmine', 'Wrinch', '1488 Annamark Crossing', 'cwrinch21@comsenz.com', '311-610-3781', '08.12.1984', 80953,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Victoir', 'Lehrer', '021 Prairieview Plaza', 'vlehrer22@purevolume.com', '237-407-7929', '02.06.2009', 80764,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hortensia', 'Hedon', '2 Crescent Oaks Lane', 'hhedon23@yellowpages.com', '943-611-1907', '10.11.2006', 72436,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Blanche', 'Axup', '6648 Johnson Court', 'baxup24@indiegogo.com', '799-747-0645', '09.11.2006', 31607,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tansy', 'Malbon', '959 Melvin Crossing', 'tmalbon25@tamu.edu', '240-564-0602', '02.10.2007', 22523,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Derick', 'Hurler', '9 Meadow Valley Pass', 'dhurler26@google.ca', '670-158-6648', '12.10.2011', 87429,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Esme', 'Ridolfo', '095 Burrows Hill', 'eridolfo27@oakley.com', '840-476-7937', '22.08.1983', 61596,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ignaz', 'Stoffersen', '90 Meadow Valley Center', 'istoffersen28@jiathis.com', '389-213-8867', '31.05.1985', 41260,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Wendell', 'Runnalls', '2 Crownhardt Pass', 'wrunnalls29@creativecommons.org', '951-838-4525', '30.09.2003', 18633,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rosabelle', 'Ginley', '14481 Mayer Terrace', 'rginley2a@bravesites.com', '156-121-6328', '24.02.1994', 95702,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dinny', 'Garnsey', '7786 Sachtjen Way', 'dgarnsey2b@mashable.com', '935-553-4214', '17.01.2017', 55180,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Aldon', 'Bartul', '09620 Longview Place', 'abartul2c@theguardian.com', '195-636-1645', '08.07.2011', 45945,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Frederique', 'Olenov', '9458 Pepper Wood Drive', 'folenov2d@php.net', '763-204-0531', '21.02.1982', 77127,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dayna', 'Wandrach', '796 Trailsway Drive', 'dwandrach2e@friendfeed.com', '581-101-7770', '11.10.2006', 11462,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Silvan', 'Kemmett', '2232 Di Loreto Street', 'skemmett2f@tiny.cc', '959-637-7430', '21.02.1988', 37291,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bianca', 'Aloshikin', '5665 Cascade Place', 'baloshikin2g@so-net.ne.jp', '156-951-6329', '03.10.1980', 47161,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Diann', 'Fullbrook', '33074 Talmadge Court', 'dfullbrook2h@java.com', '647-366-4311', '24.12.2014', 59813,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Korella', 'Davidovitch', '5 Lakeland Trail', 'kdavidovitch2i@vistaprint.com', '693-628-8575', '23.03.2017', 72398,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jacky', 'Getcliffe', '2 Utah Hill', 'jgetcliffe2j@themeforest.net', '573-735-7795', '21.05.2021', 12468,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Peria', 'Wark', '4641 Pond Hill', 'pwark2k@google.pl', '405-695-9798', '02.06.2010', 90304,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('D''arcy', 'Sawkin', '88642 Bunting Center', 'dsawkin2l@mtv.com', '175-306-3070', '08.10.1980', 44748,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lora', 'Colthard', '9 Sherman Alley', 'lcolthard2m@biblegateway.com', '403-358-9740', '21.07.2006', 74412,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Debra', 'Buscher', '4 Portage Hill', 'dbuscher2n@state.tx.us', '980-219-4740', '14.11.1982', 80557,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kameko', 'Perren', '36 Lunder Pass', 'kperren2o@apple.com', '708-779-9547', '08.10.1994', 97876,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Helenka', 'Kramer', '6986 Service Pass', 'hkramer2p@about.com', '133-750-9104', '16.08.2020', 43887,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Annecorinne', 'Moylane', '3 5th Crossing', 'amoylane2q@disqus.com', '296-437-8197', '24.02.2001', 93628,3, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Guss', 'Lehrer', '5 Harper Avenue', 'glehrer2r@i2i.jp', '283-977-4669', '25.12.2003', 83906,3, 2);

    --ALIMNOS PLAN #3 QUIMICA
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Yancey', 'Hanbidge', '06531 Anniversary Trail', 'yhanbidge0@webnode.com', '333-136-3365', '13.04.2020', 43487, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Godiva', 'Buckam', '103 Lerdahl Drive', 'gbuckam1@sciencedaily.com', '901-556-4833', '05.11.1983', 87713, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Teador', 'Plaxton', '2636 Declaration Hill', 'tplaxton2@statcounter.com', '510-983-6874', '30.01.2005', 57489, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Emerson', 'Abeau', '0382 Northridge Terrace', 'eabeau3@statcounter.com', '785-733-1896', '10.09.2001', 75352, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ashia', 'Varnam', '3 Nelson Junction', 'avarnam4@webmd.com', '283-252-5934', '11.01.2009', 15788, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Evangeline', 'Boler', '37774 Derek Point', 'eboler5@nhs.uk', '330-345-7474', '27.05.2016', 64949, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tyne', 'Hendrick', '404 Donald Plaza', 'thendrick6@sciencedirect.com', '690-653-0666', '24.08.2006', 46482, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Marga', 'White', '409 Clove Circle', 'mwhite7@apple.com', '544-360-2396', '01.02.1996', 63433, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cyril', 'Pineaux', '1560 Tony Circle', 'cpineaux8@github.io', '565-489-0591', '09.03.2005', 84627, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cord', 'Andrea', '0261 Cardinal Plaza', 'candrea9@msu.edu', '502-137-1191', '12.12.2010', 95683, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kevon', 'Olek', '2522 Di Loreto Circle', 'koleka@constantcontact.com', '453-153-6315', '16.11.2003', 72892, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Annabel', 'O''Dare', '6 Milwaukee Park', 'aodareb@wiley.com', '776-779-7269', '20.05.2019', 36822, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Georgena', 'Ducker', '4586 Bluejay Drive', 'gduckerc@discuz.net', '241-602-3126', '27.08.2005', 16169, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tarah', 'Voelker', '01483 Ridgeview Plaza', 'tvoelkerd@soup.io', '595-360-5501', '20.07.2004', 57593, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dennie', 'Uphill', '21478 Little Fleur Way', 'duphille@latimes.com', '862-371-3353', '23.04.1984', 50995, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jessamine', 'Hamblett', '22 Scott Park', 'jhamblettf@hud.gov', '201-432-7350', '13.09.2005', 69974, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Alene', 'Upcott', '57 Lerdahl Park', 'aupcottg@nbcnews.com', '847-705-2891', '09.05.1986', 83967, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kinsley', 'Rushe', '60 Lakewood Gardens Court', 'krusheh@bbb.org', '532-666-0780', '17.08.2000', 23329, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Allsun', 'Lynas', '36 Arapahoe Avenue', 'alynasi@yahoo.com', '475-456-6154', '05.10.2008', 47339, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mella', 'Sisland', '6 Glacier Hill Crossing', 'msislandj@goodreads.com', '362-552-5485', '10.05.2000', 76776, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Stewart', 'Linde', '3341 Dryden Crossing', 'slindek@pcworld.com', '420-253-0208', '26.10.2015', 29553, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dasie', 'Spaughton', '8478 Northview Hill', 'dspaughtonl@fema.gov', '546-338-4831', '07.07.1990', 62165, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Blaire', 'Dealy', '3 Lotheville Point', 'bdealym@wordpress.com', '248-157-7428', '31.08.2000', 90487, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dyanne', 'Ewbach', '82503 Sage Junction', 'dewbachn@domainmarket.com', '403-958-3520', '09.02.2016', 25826, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Guthry', 'Chipman', '433 Old Shore Center', 'gchipmano@nps.gov', '894-573-4850', '13.09.1997', 80471, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Frances', 'Van Cassel', '1237 Karstens Court', 'fvancasselp@studiopress.com', '659-701-3551', '11.05.2002', 20380, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ynes', 'Lillecrop', '1775 American Lane', 'ylillecropq@ifeng.com', '151-894-9324', '04.02.1987', 87821, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Linnell', 'Sherr', '90774 Florence Court', 'lsherrr@behance.net', '485-759-0648', '10.08.1997', 66960, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mendie', 'Thomesson', '9788 Aberg Place', 'mthomessons@t.co', '783-854-3317', '23.01.2014', 56678, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Casie', 'Piller', '497 Logan Place', 'cpillert@mac.com', '229-106-4811', '13.05.1998', 25278, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kelci', 'Quarles', '18089 Lakeland Parkway', 'kquarlesu@scribd.com', '585-240-1324', '09.05.2008', 87041, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rikki', 'Simes', '41 Dovetail Street', 'rsimesv@goo.ne.jp', '250-137-7023', '04.12.2002', 64551, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Harris', 'Meese', '102 Fallview Park', 'hmeesew@webeden.co.uk', '220-208-5271', '31.01.1998', 81391, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Minetta', 'Winfindale', '2660 Milwaukee Street', 'mwinfindalex@stumbleupon.com', '861-966-4829', '25.10.1995', 92771, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Pauline', 'Copner', '566 Hagan Park', 'pcopnery@bloomberg.com', '602-120-8580', '08.02.2009', 51445, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Karly', 'Dellenbrook', '0544 Garrison Court', 'kdellenbrookz@utexas.edu', '567-666-0029', '07.06.1995', 19023, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Parnell', 'Eaglen', '71282 Maple Point', 'peaglen10@icio.us', '894-952-5589', '16.02.1993', 77370, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sabine', 'Galgey', '6 Grasskamp Point', 'sgalgey11@blogs.com', '397-189-4087', '28.07.2018', 29996, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Natal', 'Warby', '6438 Continental Road', 'nwarby12@elegantthemes.com', '444-388-8447', '03.09.2007', 39049, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cristiano', 'Streat', '53542 Dakota Street', 'cstreat13@reddit.com', '154-485-1189', '30.09.1980', 89435, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Fitzgerald', 'Wetheril', '35 Michigan Pass', 'fwetheril14@1688.com', '115-524-7558', '10.09.2015', 31548, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mitchell', 'Blowes', '134 Sugar Park', 'mblowes15@omniture.com', '373-963-6058', '29.10.1994', 10714, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Heath', 'Marcq', '8501 Haas Alley', 'hmarcq16@seattletimes.com', '496-291-1068', '02.05.2006', 26863, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Debby', 'Cuniam', '3710 Goodland Street', 'dcuniam17@facebook.com', '585-266-1865', '20.01.2022', 26383, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gipsy', 'Leveret', '90384 Drewry Parkway', 'gleveret18@slideshare.net', '831-599-0952', '22.01.1993', 43896, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Leese', 'Etchingham', '498 Evergreen Alley', 'letchingham19@amazon.co.jp', '114-323-1633', '19.08.1992', 94918, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Niels', 'Vinau', '47350 Canary Plaza', 'nvinau1a@ebay.com', '484-618-3773', '26.07.2002', 69956, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Parke', 'Upchurch', '44515 Rusk Plaza', 'pupchurch1b@wiley.com', '544-175-0080', '15.01.2016', 37582, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mitchel', 'Deviney', '03303 Weeping Birch Hill', 'mdeviney1c@ning.com', '957-558-7119', '04.12.2014', 81189, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Elly', 'Sterrie', '62 Victoria Hill', 'esterrie1d@howstuffworks.com', '809-400-8825', '04.10.1987', 93902, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Filberto', 'Madison', '978 Jackson Street', 'fmadison1e@webs.com', '512-182-7981', '10.01.1989', 71955, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ronnie', 'de Keep', '134 Pond Plaza', 'rdekeep1f@guardian.co.uk', '422-779-5447', '02.06.2009', 12109, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Wini', 'Wetheril', '33 Laurel Trail', 'wwetheril1g@washingtonpost.com', '530-482-6108', '27.04.1996', 80275, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sutton', 'Caddell', '383 Westridge Circle', 'scaddell1h@tinypic.com', '200-171-5359', '19.06.2005', 24254, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Carrissa', 'Conti', '43 Hermina Lane', 'cconti1i@wiley.com', '739-343-6803', '26.02.1986', 13984, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hillel', 'Joint', '8014 Golden Leaf Drive', 'hjoint1j@example.com', '259-958-9581', '20.12.2013', 72061, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kerr', 'Metterick', '47392 Hollow Ridge Avenue', 'kmetterick1k@mac.com', '342-704-0663', '14.09.2002', 19050, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Merry', 'Harlock', '3730 Harper Center', 'mharlock1l@nytimes.com', '860-945-7147', '18.07.2004', 47167, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cissy', 'Clausen', '756 Corscot Alley', 'cclausen1m@sciencedaily.com', '738-745-6865', '19.03.2004', 33099, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lily', 'Meharry', '41976 Ludington Center', 'lmeharry1n@tmall.com', '577-603-3958', '30.10.1994', 26630, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Skipton', 'Boshier', '4891 Mallard Park', 'sboshier1o@europa.eu', '490-946-9666', '12.07.1984', 36629, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Reinaldos', 'Kilshaw', '4 Hermina Park', 'rkilshaw1p@noaa.gov', '951-770-9293', '08.03.1998', 45708, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Emmalynn', 'Jordan', '1088 Mcbride Pass', 'ejordan1q@buzzfeed.com', '497-411-2799', '28.09.2009', 15360, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Holly', 'Danslow', '7 Park Meadow Court', 'hdanslow1r@t-online.de', '144-500-4193', '27.03.1986', 81514, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dannel', 'Gerritsma', '9557 Kipling Terrace', 'dgerritsma1s@psu.edu', '532-797-1551', '29.10.2018', 71005, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Zita', 'Farney', '1944 Sommers Crossing', 'zfarney1t@linkedin.com', '601-288-9539', '26.12.2002', 80068, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lilias', 'Raoux', '90168 Old Gate Way', 'lraoux1u@cbsnews.com', '335-855-2416', '30.06.2010', 23999, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hersh', 'Drysdall', '22705 Golf Terrace', 'hdrysdall1v@wikipedia.org', '715-899-9436', '03.03.1991', 90286, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Chrissie', 'Filchakov', '2 Troy Pass', 'cfilchakov1w@digg.com', '648-594-4681', '01.10.2011', 41953, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ulrika', 'Bentham3', '5 Cardinal Alley', 'ubentham1x@hexun.com', '858-858-9534', '17.08.1997', 35922, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lynn', 'Wark', '3962 Sugar Pass', 'lwark1y@businessweek.com', '202-902-5564', '27.02.2011', 89231, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Shelly', 'Chrisp', '8 Eastlawn Street', 'schrisp1z@squidoo.com', '295-770-5435', '16.07.1994', 30731, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Colan', 'Aubrey', '9 Holy Cross Plaza', 'caubrey20@wiley.com', '686-342-3520', '22.06.2010', 73746, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Veronika', 'Gowenlock', '6 Farmco Court', 'vgowenlock21@sciencedaily.com', '804-270-6045', '01.04.2004', 34630, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gav', 'Mattiessen', '7989 Mcguire Crossing', 'gmattiessen22@apple.com', '338-185-8422', '10.12.2021', 12477, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Vivyan', 'MacLese', '16343 Charing Cross Place', 'vmaclese23@imgur.com', '581-231-3227', '22.03.2012', 61114, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Parke', 'Cressar', '6 Cambridge Street', 'pcressar24@alexa.com', '275-383-2207', '03.07.1982', 14968, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Aimil', 'Vispo', '059 Carpenter Point', 'avispo25@hostgator.com', '833-592-0820', '29.09.1984', 22604, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Terri', 'Renols', '29782 Elka Plaza', 'trenols26@nature.com', '114-601-2073', '24.05.2006', 54438, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Marcus', 'Giacomasso', '5943 Esker Lane', 'mgiacomasso27@sina.com.cn', '413-633-3695', '21.02.2011', 83824, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Calypso', 'Zapata', '36 Sauthoff Way', 'czapata28@netscape.com', '762-514-1798', '12.10.1989', 94826, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Eddie', 'Alessandretti', '191 Fair Oaks Crossing', 'ealessandretti29@wp.com', '717-848-0714', '06.04.2014', 45274, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ilario', 'Ferro', '92603 Warrior Road', 'iferro2a@hatena.ne.jp', '597-148-0037', '11.08.2005', 40082, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cindra', 'McGavin', '99531 Hoffman Drive', 'cmcgavin2b@ted.com', '545-614-9290', '06.02.2003', 22047, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Coralyn', 'Kinghorne', '71906 East Terrace', 'ckinghorne2c@wix.com', '291-424-8869', '25.02.1981', 98020, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kerstin', 'Douche', '5282 Bunting Pass', 'kdouche2d@vkontakte.ru', '260-855-0103', '18.01.2018', 41423, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Payton', 'Whittock', '90101 Gerald Park', 'pwhittock2e@google.co.uk', '212-332-0031', '11.02.1995', 47251, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dalt', 'Rockcliffe', '7 Waywood Road', 'drockcliffe2f@cmu.edu', '685-377-2901', '11.03.1993', 87030, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Amitie', 'Avieson', '21 Elka Center', 'aavieson2g@yahoo.com', '185-802-1416', '03.04.1987', 34989, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ava', 'Stanworth', '723 Grover Junction', 'astanworth2h@naver.com', '397-658-3301', '08.10.2013', 29264, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kaleb', 'Schober', '688 Glacier Hill Pass', 'kschober2i@upenn.edu', '371-215-2468', '05.03.1994', 89237, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lil', 'Ledster', '19828 Old Shore Drive', 'lledster2j@wikia.com', '822-691-2575', '24.02.2019', 47995, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Virge', 'Cattermull', '12440 Namekagon Park', 'vcattermull2k@ifeng.com', '533-594-1124', '16.02.2015', 79438, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Electra', 'Alennikov', '934 Rutledge Street', 'ealennikov2l@google.nl', '316-541-6426', '26.12.1983', 69595, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Torey', 'Kingswold', '8044 Maywood Circle', 'tkingswold2m@indiatimes.com', '229-576-7692', '19.01.1987', 41866, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Pavia', 'Cuskery', '9273 Kedzie Pass', 'pcuskery2n@boston.com', '502-504-4342', '25.08.1993', 89803, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Deloria', 'Bevan', '7 Susan Avenue', 'dbevan2o@cafepress.com', '964-353-4634', '06.10.1996', 25162, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ilaire', 'Geffen', '69317 Chive Trail', 'igeffen2p@unblog.fr', '455-423-4712', '08.05.2006', 37620, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Maisey', 'Tant', '6 Oneill Way', 'mtant2q@ning.com', '471-766-3513', '05.01.1981', 81671, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Codi', 'Scottrell', '0 Menomonie Drive', 'cscottrell2r@shinystat.com', '143-916-4825', '22.04.1986', 29490, 3, 3);
        --
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Karen', 'Lepere', '6 Vernon Way', 'klepere0@ucoz.com', '968-719-0951', '10.06.2009', 17415, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Leeland', 'Di Biagio', '844 Stuart Plaza', 'ldibiagio1@blogtalkradio.com', '690-292-5356', '24.04.1999', 86980, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rebeca', 'Restall', '76533 Maryland Road', 'rrestall2@ibm.com', '162-512-8395', '05.09.2003', 87008, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lavinia', 'Oland', '171 Shasta Way', 'loland3@disqus.com', '701-679-0160', '28.12.2003', 46101, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dalston', 'Galway', '87 Browning Point', 'dgalway4@answers.com', '490-574-8837', '03.12.1983', 55773, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gerik', 'Spurryer', '597 Summer Ridge Plaza', 'gspurryer5@ihg.com', '725-604-5505', '11.08.1989', 13352, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Filmore', 'Caldwall', '79 Dorton Place', 'fcaldwall6@huffingtonpost.com', '581-382-8216', '15.01.2005', 59925, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Seward', 'Willerstone', '3 Pine View Terrace', 'swillerstone7@cloudflare.com', '471-178-1662', '03.05.1990', 23661, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cherlyn', 'Kerrane', '36909 Sugar Avenue', 'ckerrane8@ucsd.edu', '878-496-6449', '17.06.2005', 42156, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lynne', 'Hammel', '35884 School Court', 'lhammel9@yandex.ru', '901-198-7654', '12.11.2012', 44916, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Livvyy', 'De Meyer', '3 Morningstar Place', 'ldemeyera@desdev.cn', '605-321-6800', '20.03.1996', 69655, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Palmer', 'Oglesbee', '79 Shoshone Trail', 'poglesbeeb@stumbleupon.com', '801-771-3592', '23.08.2005', 96663, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tressa', 'Fackney', '250 Dottie Junction', 'tfackneyc@wufoo.com', '838-434-7203', '08.09.1981', 51196, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Carissa', 'Canet', '83 Daystar Lane', 'ccanetd@imdb.com', '133-856-8120', '06.03.1994', 99068, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Farly', 'Haldene', '69129 Cordelia Plaza', 'fhaldenee@uiuc.edu', '936-161-2528', '03.03.1985', 39311, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Susanetta', 'Siveter', '86807 Kings Court', 'ssiveterf@sfgate.com', '332-411-0078', '24.11.2011', 20842, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Shepherd', 'McKain', '58 Porter Circle', 'smckaing@nih.gov', '740-297-5918', '19.07.2001', 64565, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gustavus', 'Carolan', '74516 Paget Pass', 'gcarolanh@usatoday.com', '349-288-4667', '09.09.2006', 19431, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tasia', 'Cambridge', '533 Corscot Park', 'tcambridgei@sakura.ne.jp', '657-710-9509', '19.09.1982', 28711, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Erda', 'Narracott', '71907 Sycamore Alley', 'enarracottj@berkeley.edu', '204-848-3371', '04.08.2005', 29291, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Pauline', 'O''Hartnedy', '219 Westport Trail', 'pohartnedyk@amazon.com', '275-314-8977', '28.04.1989', 86343, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Vidovik', 'Yakunikov', '06 Sachs Avenue', 'vyakunikovl@flavors.me', '277-685-3543', '16.08.1993', 24972, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Linea', 'Curner', '59845 Park Meadow Alley', 'lcurnerm@dagondesign.com', '247-458-8025', '17.08.2010', 21838, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Carmela', 'Stoneham', '886 Monument Street', 'cstonehamn@ucoz.ru', '967-596-4170', '16.12.1992', 50844, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Barthel', 'Dufaur', '077 Dorton Center', 'bdufauro@hp.com', '467-441-8792', '21.01.2000', 60735, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cindie', 'Darwin', '9392 Spenser Road', 'cdarwinp@livejournal.com', '934-416-8068', '17.07.1990', 88943, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hakeem', 'Kubicek', '6 Vera Hill', 'hkubicekq@w3.org', '619-212-4753', '14.08.2010', 59852, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Evvie', 'Caton', '19 Loomis Center', 'ecatonr@indiegogo.com', '859-399-6610', '19.05.2016', 66849, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Del', 'Champniss', '44858 3rd Avenue', 'dchampnisss@merriam-webster.com', '942-966-8901', '20.10.2001', 31419, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nefen', 'Rawstorne', '93828 Carey Street', 'nrawstornet@sourceforge.net', '782-626-1707', '20.08.2015', 51752, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Eugene', 'Hanna', '9 Toban Lane', 'ehannau@hibu.com', '713-848-1599', '30.07.1998', 52054, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Brittani', 'Matyukon', '703 Farwell Trail', 'bmatyukonv@bloglovin.com', '414-110-1454', '02.05.1995', 17641, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cherilyn', 'Bartoletti', '39406 Myrtle Place', 'cbartolettiw@opensource.org', '499-890-2345', '20.07.2007', 68149, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gustaf', 'Speere', '08 Moulton Alley', 'gspeerex@java.com', '834-454-2611', '25.03.2009', 62715, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ernest', 'Kaesmakers', '0818 Arrowood Way', 'ekaesmakersy@amazon.co.jp', '943-806-0107', '15.12.1988', 66882, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sandy', 'Boswood', '3233 Oriole Terrace', 'sboswoodz@goo.gl', '694-111-9353', '15.05.1982', 66662, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Morgan', 'Milbank', '8968 Glendale Plaza', 'mmilbank10@java.com', '580-396-8925', '20.11.1999', 70545, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Vassili', 'Laurencot', '9 Glendale Plaza', 'vlaurencot11@engadget.com', '894-163-4032', '24.01.2022', 27850, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cissy', 'Hamner', '0928 Kedzie Junction', 'chamner12@cyberchimps.com', '688-541-5002', '03.04.2005', 91903, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sawyere', 'Brenton', '37 East Street', 'sbrenton13@cnbc.com', '718-100-4818', '19.07.2008', 49255, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Elmore', 'MacFayden', '07 Jenifer Plaza', 'emacfayden14@tinypic.com', '149-209-1211', '01.07.2019', 40989, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Eleonore', 'Samme', '3404 Riverside Place', 'esamme15@rakuten.co.jp', '751-763-6130', '17.04.2016', 43556, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ulrich', 'Lugsdin', '53 Eggendart Park', 'ulugsdin16@spiegel.de', '573-637-6622', '21.08.2002', 43490, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Winthrop', 'Hanster', '87884 Forster Circle', 'whanster17@wordpress.com', '735-966-1821', '16.11.1980', 57190, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ase', 'Godber', '10 Monica Road', 'agodber18@techcrunch.com', '560-192-9507', '15.09.1999', 32531, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Collie', 'Thirtle', '92 Spaight Court', 'cthirtle19@sbwire.com', '649-543-0327', '14.01.2020', 73750, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kylila', 'Gomersall', '12940 Kingsford Pass', 'kgomersall1a@telegraph.co.uk', '372-110-4648', '19.01.1992', 99256, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Krystalle', 'Dobrowolski', '3701 Mayfield Crossing', 'kdobrowolski1b@accuweather.com', '292-365-2530', '02.07.2016', 51823, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ellyn', 'Briant', '35037 Utah Junction', 'ebriant1c@gnu.org', '308-204-7661', '25.09.2017', 43987, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Trixi', 'Pengelly', '9070 4th Plaza', 'tpengelly1d@tinypic.com', '512-602-1745', '22.10.2003', 10975, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jackquelin', 'Hagston', '121 Dexter Court', 'jhagston1e@blinklist.com', '979-684-0047', '30.12.2010', 43935, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hayley', 'Pynn', '7264 Warrior Court', 'hpynn1f@hugedomains.com', '184-242-0899', '24.06.1990', 25194, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gunar', 'Walesby', '5 Cascade Drive', 'gwalesby1g@ox.ac.uk', '910-160-2562', '13.07.1995', 71786, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Katine', 'Toman', '66645 Cody Drive', 'ktoman1h@blogs.com', '355-334-0742', '10.11.1993', 64090, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ax', 'Fedorski', '10201 Lake View Terrace', 'afedorski1i@va.gov', '887-249-6167', '04.05.1982', 21614, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Guy', 'Wallwood', '04910 Forest Run Crossing', 'gwallwood1j@wikia.com', '709-201-3806', '09.01.2018', 23134, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ozzie', 'Soda', '57 3rd Terrace', 'osoda1k@admin.ch', '621-463-8314', '03.09.2003', 84326, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Andee', 'Reynard', '71 Kedzie Crossing', 'areynard1l@google.ru', '757-791-4144', '03.09.2009', 58779, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Angel', 'Gravie', '851 Banding Way', 'agravie1m@t-online.de', '508-905-4745', '30.11.1986', 17809, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bernardo', 'Tregona', '3 Cottonwood Crossing', 'btregona1n@google.ru', '374-542-3988', '07.12.1983', 58952, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sal', 'Januszkiewicz', '65 Forest Run Court', 'sjanuszkiewicz1o@themeforest.net', '850-365-5697', '23.04.2007', 71743, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Annemarie', 'Bartel', '7 Meadow Valley Point', 'abartel1p@ebay.co.uk', '896-386-4415', '01.07.2010', 25634, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mack', 'Woolstenholmes', '1 Cottonwood Court', 'mwoolstenholmes1q@discovery.com', '322-594-0221', '16.03.1987', 41356, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Augy', 'Bowdler', '18133 Longview Hill', 'abowdler1r@nsw.gov.au', '514-352-1299', '22.12.2015', 62718, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tynan', 'Cuddon', '3 Bartelt Park', 'tcuddon1s@cargocollective.com', '427-804-0335', '09.10.1994', 84853, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Van', 'Han', '4789 Gateway Crossing', 'vhan1t@opera.com', '145-492-3457', '06.08.1998', 27241, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Olivie', 'Godden', '035 Bashford Crossing', 'ogodden1u@gov.uk', '664-650-7410', '13.10.1985', 66481, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Linc', 'Dockrill', '6386 Vermont Pass', 'ldockrill1v@tuttocitta.it', '846-501-6245', '13.03.1990', 11995, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dore', 'Ahrenius', '8279 John Wall Drive', 'dahrenius1w@webnode.com', '511-371-2630', '03.05.2004', 27464, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ettie', 'Roscher', '1 Hoepker Junction', 'eroscher1x@imageshack.us', '745-371-1549', '01.02.2000', 87462, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Shandie', 'Klosges', '4477 Calypso Terrace', 'sklosges1y@mashable.com', '437-673-3712', '27.11.2009', 61427, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jelene', 'Brown', '5 Northport Lane', 'jbrown1z@rediff.com', '512-617-1277', '19.12.2011', 47186, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tanny', 'Packer', '84 Oak Valley Court', 'tpacker20@utexas.edu', '236-147-1330', '02.03.2010', 26438, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dionne', 'Grent', '2941 Fordem Center', 'dgrent21@springer.com', '782-173-7524', '25.10.2003', 70886, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Henrie', 'Canero', '87125 Kennedy Hill', 'hcanero22@stumbleupon.com', '979-140-7599', '29.08.1990', 62799, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sebastien', 'Cookley', '5 Bayside Street', 'scookley23@behance.net', '978-460-6725', '11.06.2002', 98425, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Payton', 'Landal', '96 Dayton Drive', 'plandal24@stumbleupon.com', '567-505-9194', '22.12.1992', 29798, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Halsy', 'Coats', '921 Continental Court', 'hcoats25@smugmug.com', '298-512-3392', '02.04.1989', 44994, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Johanna', 'Cohn', '29 6th Drive', 'jcohn26@washington.edu', '223-179-0881', '29.04.1983', 62892, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lory', 'Van den Broek', '5 Rowland Terrace', 'lvandenbroek27@java.com', '334-494-8624', '05.08.1996', 32728, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jillayne', 'Belvard', '765 Everett Road', 'jbelvard28@yelp.com', '934-602-4834', '25.09.1985', 95788, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Coralyn', 'Glandon', '24249 Nobel Avenue', 'cglandon29@state.tx.us', '176-940-4058', '04.01.1999', 91129, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hurleigh', 'Vanichkin', '96 Moulton Hill', 'hvanichkin2a@google.pl', '923-286-1465', '01.02.2005', 95112, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Natale', 'McNeil', '8 Brown Hill', 'nmcneil2b@com.com', '430-344-0787', '26.11.1992', 64344, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Terrill', 'Conkey', '111 Melody Alley', 'tconkey2c@sina.com.cn', '233-111-7681', '09.01.2014', 19736, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Clementina', 'Ousby', '35 Springview Way', 'cousby2d@ocn.ne.jp', '411-363-2616', '25.09.2014', 44784, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Clementius', 'Capoun', '1 Mitchell Way', 'ccapoun2e@yahoo.com', '573-227-8611', '07.07.2006', 34335, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Andre', 'Ick', '8033 Bayside Street', 'aick2f@cdbaby.com', '915-815-6917', '16.08.1990', 46418, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Pembroke', 'Sallis', '2 Judy Point', 'psallis2g@guardian.co.uk', '894-653-9247', '24.07.2011', 76611, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Manon', 'Pautard', '74 Sunnyside Road', 'mpautard2h@about.me', '557-801-3695', '20.10.2003', 17574, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Isa', 'Simmank', '81 Dapin Plaza', 'isimmank2i@eventbrite.com', '503-164-8376', '13.10.2007', 66691, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mac', 'O''Duilleain', '46 Arapahoe Alley', 'moduilleain2j@mit.edu', '486-313-2457', '10.01.1990', 74804, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Michaella', 'Kinvig', '72187 Esker Point', 'mkinvig2k@jimdo.com', '839-979-4470', '04.08.1996', 20311, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Fedora', 'Osmon', '5 Havey Plaza', 'fosmon2l@yellowbook.com', '457-598-8013', '27.10.1989', 73283, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ag', 'Fanthom', '28 Messerschmidt Park', 'afanthom2m@vistaprint.com', '841-609-0898', '16.10.2018', 24784, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cully', 'Lawrenson', '7 Comanche Pass', 'clawrenson2n@taobao.com', '452-995-6369', '05.04.2011', 13849, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sheila-kathryn', 'Brogan', '958 Hanson Terrace', 'sbrogan2o@prweb.com', '496-892-5048', '14.05.1996', 20690, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Chris', 'Crome', '65 Mallard Lane', 'ccrome2p@slideshare.net', '224-460-6015', '20.07.2009', 39955, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Trevar', 'Skillicorn', '3034 Clyde Gallagher Alley', 'tskillicorn2q@goodreads.com', '273-682-8877', '17.02.2003', 11993, 3, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Vaclav', 'Rowlett', '056 Shasta Crossing', 'vrowlett2r@rediff.com', '705-306-3062', '26.03.2009', 31090, 3, 3);
    --
--PROFESORES
    --PROFESORES CON PLAN #1
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Glendon', 'Francescuzzi', '8179 Spohn Junction', 'gfrancescuzzi0@indiegogo.com', '409-860-5254', '12.06.2008', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rickard', 'Brierley', '7 Gina Terrace', 'rbrierley1@redcross.org', '382-796-3947', '07.12.1983', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Binni', 'Vedyasov', '0 Mayfield Parkway', 'bvedyasov2@blogger.com', '613-450-1276', '19.09.1997', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rupert', 'Tarbett', '1 Farmco Court', 'rtarbett3@newsvine.com', '637-560-0836', '20.01.2008', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kerk', 'Putland', '90 Cordelia Way', 'kputland4@tripadvisor.com', '801-581-2506', '18.01.1992', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jeane', 'Walder', '34115 Mesta Trail', 'jwalder5@ft.com', '404-411-2179', '27.10.2004', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Florence', 'Hanney', '54571 Parkside Trail', 'fhanney6@huffingtonpost.com', '801-281-7777', '26.01.2021', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Damien', 'Matteoli', '72 Hayes Crossing', 'dmatteoli7@amazonaws.com', '862-713-3081', '03.05.2014', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Pauline', 'Buckwell', '7 Judy Junction', 'pbuckwell8@squidoo.com', '985-822-5654', '19.12.1985', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ingamar', 'Sausman', '52 Morning Parkway', 'isausman9@state.tx.us', '420-288-5455', '23.07.1991', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Pattie', 'Petroselli', '13 Rowland Road', 'ppetrosellia@msn.com', '595-429-2913', '13.06.2000', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bil', 'Doxsey', '655 Karstens Plaza', 'bdoxseyb@github.io', '644-381-8171', '25.09.2018', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Amalle', 'Oliveira', '536 Farmco Center', 'aoliveirac@imgur.com', '803-251-6482', '19.02.1993', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lester', 'Osselton', '480 Waubesa Junction', 'losseltond@ft.com', '581-171-6820', '03.01.2022', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nydia', 'McCheyne', '7 Bunker Hill Trail', 'nmccheynee@harvard.edu', '395-606-4066', '29.05.2001', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sonya', 'Wollen', '92634 Walton Way', 'swollenf@apache.org', '542-751-2160', '02.11.2002', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tedda', 'Newbery', '778 Petterle Terrace', 'tnewberyg@etsy.com', '381-522-3955', '29.10.2007', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Perry', 'Sant', '2688 Upham Trail', 'psanth@ocn.ne.jp', '387-168-2298', '22.07.1997', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Raynor', 'Profit', '69 Florence Hill', 'rprofiti@house.gov', '736-278-6655', '14.10.2004', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Toma', 'Gallardo', '441 Red Cloud Plaza', 'tgallardoj@accuweather.com', '335-991-7626', '08.08.2015', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lois', 'Skouling', '3378 Armistice Center', 'lskoulingk@privacy.gov.au', '123-972-7728', '06.10.1991', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Korie', 'Pedro', '84732 Old Gate Lane', 'kpedrol@mashable.com', '124-341-8183', '21.11.1985', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Alysa', 'Curm', '153 Packers Circle', 'acurmm@angelfire.com', '629-270-4347', '27.08.1997', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Libby', 'Klaiser', '8 Golf Terrace', 'lklaisern@fotki.com', '733-276-0705', '10.08.2007', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Griffy', 'Wrenn', '61557 Nova Lane', 'gwrenno@shinystat.com', '808-482-7317', '19.04.2007', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Meaghan', 'Grady', '7 Colorado Road', 'mgradyp@hud.gov', '811-548-8453', '21.12.2014', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Maris', 'Fist', '0411 Waxwing Park', 'mfistq@sourceforge.net', '918-788-7488', '08.02.1995', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Brocky', 'Pancast', '8 Toban Point', 'bpancastr@prlog.org', '821-682-3674', '06.08.2014', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jayme', 'Pargetter', '128 Holmberg Trail', 'jpargetters@toplist.cz', '620-699-6275', '27.10.2004', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Chuck', 'Le Fleming', '4 Straubel Junction', 'cleflemingt@123-reg.co.uk', '326-216-0051', '08.06.1982', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Manfred', 'Vear', '2543 Logan Lane', 'mvearu@shareasale.com', '355-236-9253', '29.10.2010', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tamas', 'Hake', '735 Butternut Drive', 'thakev@comcast.net', '725-815-6560', '05.06.1982', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cecil', 'Grafton', '695 Golden Leaf Point', 'cgraftonw@cbc.ca', '568-227-9252', '06.01.1989', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Judd', 'Sloley', '267 Vidon Road', 'jsloleyx@howstuffworks.com', '437-117-6084', '04.07.2010', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hebert', 'Rehn', '1108 Rockefeller Alley', 'hrehny@cargocollective.com', '757-767-9260', '04.05.1987', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gwenore', 'Ahrens', '466 Westridge Pass', 'gahrensz@fda.gov', '567-962-2158', '13.07.1981', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sergent', 'Seargeant', '81 Bluestem Terrace', 'sseargeant10@xrea.com', '975-917-8201', '05.11.2003', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Janean', 'Rook', '21039 Lakewood Gardens Way', 'jrook11@instagram.com', '496-914-9820', '22.02.1998', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Trixie', 'Landall', '062 Scofield Alley', 'tlandall12@dailymotion.com', '243-666-6721', '23.02.1997', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Noel', 'Lambard', '1357 Little Fleur Hill', 'nlambard13@harvard.edu', '517-958-5230', '08.07.1982', 0, 2, 1);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ericka', 'Eudall', '947 David Crossing', 'eeudall14@boston.com', '839-722-1240', '27.05.2018', 0, 2, 1);
    --
    --PROFESORES CON PLAN #2
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Aliza', 'Hulmes', '325 Pierstorff Drive', 'ahulmes0@biglobe.ne.jp', '457-905-5411', '17.04.2014', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Meryl', 'Brettoner', '8627 Sachtjen Court', 'mbrettoner1@loc.gov', '996-688-5911', '15.01.2018', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Herrick', 'Everal', '5 Moland Road', 'heveral2@accuweather.com', '883-855-7787', '09.02.2010', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Giulietta', 'Harradine', '84654 Kim Crossing', 'gharradine3@addtoany.com', '964-455-1672', '27.12.2020', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Estel', 'Styles', '83432 Coolidge Plaza', 'estyles4@taobao.com', '513-265-3275', '03.08.2017', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Zelig', 'Tayler', '29 Melby Parkway', 'ztayler5@miitbeian.gov.cn', '200-255-2922', '10.05.2018', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ly', 'Duesberry', '2989 Del Sol Avenue', 'lduesberry6@census.gov', '484-930-6734', '17.05.2020', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Leslie', 'Grice', '0 Tennessee Street', 'lgrice7@cloudflare.com', '804-994-3363', '22.02.2007', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Koralle', 'Slewcock', '31 Marcy Trail', 'kslewcock8@tmall.com', '234-461-0883', '11.01.2021', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hermina', 'Ferrarotti', '9 Harper Park', 'hferrarotti9@wp.com', '867-896-6465', '18.08.1986', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cass', 'Vittle', '1 Fallview Terrace', 'cvittlea@mashable.com', '143-877-5531', '27.10.2020', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Brade', 'Althorpe', '1 Elka Avenue', 'balthorpeb@reference.com', '505-766-0002', '02.02.1985', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sibylla', 'Rennix', '8148 Cherokee Plaza', 'srennixc@mapy.cz', '325-216-6419', '18.05.2015', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Laurette', 'Marwood', '831 Bartillon Way', 'lmarwoodd@mayoclinic.com', '336-150-5363', '25.06.2000', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tomasina', 'Facey', '0342 Hoffman Way', 'tfaceye@cbsnews.com', '249-147-8714', '06.01.1986', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Valida', 'Coning', '76931 Lien Alley', 'vconingf@taobao.com', '856-370-5971', '22.01.2006', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Charlean', 'Chatenier', '3 Burning Wood Road', 'cchatenierg@hao123.com', '996-728-8403', '14.11.2001', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Marci', 'Ellerby', '4224 Hayes Crossing', 'mellerbyh@histats.com', '256-556-2994', '11.04.1999', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kin', 'Tremontana', '25681 Dakota Center', 'ktremontanai@msu.edu', '972-230-5203', '28.07.2013', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bobbee', 'Backhurst', '0 Rusk Lane', 'bbackhurstj@usda.gov', '242-945-6564', '22.03.2001', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ginevra', 'Reichert', '874 Marquette Lane', 'greichertk@sakura.ne.jp', '724-587-5350', '12.03.2019', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kelcey', 'Adshed', '31 Stuart Plaza', 'kadshedl@furl.net', '765-663-7891', '12.12.2007', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Greggory', 'Poel', '3732 Gulseth Terrace', 'gpoelm@shareasale.com', '519-639-8294', '26.06.1996', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Wilmar', 'Gredden', '725 Di Loreto Terrace', 'wgreddenn@marketwatch.com', '293-117-7138', '24.11.2014', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rolf', 'Geffcock', '7 Kings Trail', 'rgeffcocko@cbsnews.com', '934-773-8884', '06.06.1999', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Howard', 'Frend', '5522 Lakeland Hill', 'hfrendp@mozilla.org', '456-142-4976', '01.10.2005', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kelli', 'Treneer', '16449 Elgar Drive', 'ktreneerq@privacy.gov.au', '284-569-7890', '23.08.1987', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Alyda', 'Blessed', '5 Linden Lane', 'ablessedr@omniture.com', '801-717-2120', '06.09.2020', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Marybelle', 'Scamal', '4 3rd Crossing', 'mscamals@google.ca', '543-195-5747', '10.05.2018', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Enid', 'Clute', '95630 Anderson Court', 'eclutet@discovery.com', '705-514-7903', '03.06.1983', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Oralia', 'Keeton', '24 Blue Bill Park Plaza', 'okeetonu@fda.gov', '429-357-8656', '02.07.2015', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Vinnie', 'Presho', '131 Truax Junction', 'vpreshov@t-online.de', '692-366-5262', '25.06.1991', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Waylin', 'Tolumello', '748 Knutson Drive', 'wtolumellow@ftc.gov', '289-749-0438', '18.10.2002', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Stace', 'Alldis', '18 Randy Center', 'salldisx@reverbnation.com', '403-115-9240', '27.04.1983', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Rebekkah', 'Soppeth', '61 Esker Way', 'rsoppethy@msn.com', '383-952-3801', '31.10.1985', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sari', 'Kusick', '0804 Golf View Street', 'skusickz@creativecommons.org', '246-269-9367', '17.02.1994', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Bertram', 'Andrat', '43915 Nevada Pass', 'bandrat10@state.tx.us', '842-301-6259', '13.09.1987', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Guy', 'Achurch', '7 Forster Avenue', 'gachurch11@deliciousdays.com', '513-483-8525', '01.01.1985', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Nelson', 'Symons', '4 5th Hill', 'nsymons12@buzzfeed.com', '920-605-9719', '07.03.2015', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Sibilla', 'Corah', '8966 Village Green Terrace', 'scorah13@marriott.com', '983-982-5338', '22.10.2002', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Mickie', 'Duthy', '5 Prairieview Hill', 'mduthy14@ucla.edu', '796-231-7327', '14.12.1994', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Eddie', 'Mace', '94 Ludington Trail', 'emace15@baidu.com', '407-134-4395', '16.10.2010', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kendell', 'Kenton', '50 Loomis Hill', 'kkenton16@illinois.edu', '623-563-2010', '31.10.1992', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Scarlett', 'Squires', '1 Buhler Parkway', 'ssquires17@prlog.org', '759-195-1332', '15.11.2009', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Andria', 'Crim', '80319 Spenser Junction', 'acrim18@cnbc.com', '425-413-8159', '02.03.2017', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Davida', 'Allin', '920 Oakridge Way', 'dallin19@whitehouse.gov', '688-380-4926', '15.04.2009', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Adelbert', 'Norquay', '37592 Lunder Drive', 'anorquay1a@yandex.ru', '553-112-4006', '31.05.1983', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Killian', 'Crummey', '894 Spaight Trail', 'kcrummey1b@google.de', '831-870-5022', '15.12.2001', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Elspeth', 'Saurat', '5267 Bayside Place', 'esaurat1c@myspace.com', '316-718-8756', '09.01.1998', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Cristian', 'Danslow', '05 Main Terrace', 'cdanslow1d@comsenz.com', '344-184-1245', '18.07.2014', 0, 2, 2);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Garold', 'Roache', '32 Main Center', 'groache1e@bing.com', '774-840-0544', '21.06.1989', 0, 2, 2);
    --
    --PROFESORES CON PLAN #3
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tabor', 'Janaway', '46 Mesta Crossing', 'tjanaway0@archive.org', '178-835-6892', '21.12.1982', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ilene', 'Garrattley', '00169 Bobwhite Hill', 'igarrattley1@stumbleupon.com', '481-889-6928', '25.06.1984', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Emmett', 'Suff', '6 Hoepker Junction', 'esuff2@bloglines.com', '935-174-1584', '01.12.2013', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Katherina', 'Gniewosz', '259 1st Road', 'kgniewosz3@zimbio.com', '533-733-4272', '31.12.1992', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lyndel', 'Roumier', '45587 Dawn Hill', 'lroumier4@wikispaces.com', '499-869-4109', '10.01.2019', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ninetta', 'Smelley', '94 Bellgrove Way', 'nsmelley5@squarespace.com', '186-268-2986', '24.02.2009', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jessie', 'Bonome', '21495 Esch Way', 'jbonome6@gnu.org', '732-175-8227', '07.01.2005', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Marillin', 'Ollive', '735 American Court', 'mollive7@sbwire.com', '363-744-7691', '05.12.2004', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Aundrea', 'Vigours', '125 Waxwing Circle', 'avigours8@amazon.com', '719-617-1635', '10.05.1994', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Devon', 'Maro', '61186 Lien Pass', 'dmaro9@hubpages.com', '738-480-3322', '28.10.1987', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Peria', 'Lampke', '47304 Hoard Park', 'plampkea@clickbank.net', '870-627-4429', '06.10.2008', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Chevy', 'Staneland', '12 Helena Trail', 'cstanelandb@mtv.com', '219-265-7674', '13.12.1993', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Joelly', 'Blodget', '449 Glendale Pass', 'jblodgetc@barnesandnoble.com', '813-328-9442', '28.04.2017', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Samaria', 'Anyene', '169 Lillian Junction', 'sanyened@dagondesign.com', '398-175-7970', '14.01.2007', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Isadora', 'Issacof', '9091 Lunder Street', 'iissacofe@vkontakte.ru', '927-986-1648', '10.10.1989', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ellwood', 'Evenden', '1867 Vera Circle', 'eevendenf@latimes.com', '256-858-2038', '29.06.1986', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Adrian', 'Wield', '4778 Mifflin Point', 'awieldg@pbs.org', '410-563-2717', '28.10.2002', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Francine', 'McCully', '90580 Prairie Rose Road', 'fmccullyh@slate.com', '621-645-3417', '30.08.2017', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Tobin', 'Tafani', '1 Goodland Center', 'ttafanii@hp.com', '977-818-7175', '22.01.2015', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Celisse', 'Linke', '51100 Fallview Place', 'clinkej@biblegateway.com', '795-671-0387', '10.10.1983', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Malachi', 'McGlaud', '7 Main Street', 'mmcglaudk@home.pl', '749-529-1110', '06.08.2015', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Odo', 'MacMickan', '1935 Shopko Crossing', 'omacmickanl@oakley.com', '344-119-0857', '29.10.1986', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Constantine', 'MacArte', '54512 Bartelt Alley', 'cmacartem@rambler.ru', '354-425-3140', '20.08.1984', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Orbadiah', 'Spadelli', '660 Nelson Avenue', 'ospadellin@nbcnews.com', '166-148-1924', '23.07.2011', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ali', 'Flaunders', '2 Continental Junction', 'aflaunderso@twitter.com', '478-615-8284', '24.04.2011', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Laverne', 'Carwithen', '7 Logan Alley', 'lcarwithenp@archive.org', '705-671-2506', '28.07.1993', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Maria', 'Sisse', '11707 Mendota Trail', 'msisseq@cpanel.net', '865-730-7526', '04.02.1994', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Aguste', 'Boat', '86 Merrick Pass', 'aboatr@blogtalkradio.com', '318-939-7703', '23.06.2011', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Clemmie', 'Schutte', '14 Mcguire Crossing', 'cschuttes@is.gd', '425-855-1263', '28.02.1988', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Jillian', 'Pierpoint', '5 Corry Lane', 'jpierpointt@blinklist.com', '860-452-5433', '01.06.1995', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dannye', 'Brodnecke', '5935 Gerald Park', 'dbrodneckeu@e-recht24.de', '696-580-9102', '16.02.2009', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Toby', 'Harmeston', '85 Westport Avenue', 'tharmestonv@google.nl', '773-333-3380', '01.08.2019', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Agathe', 'Stebles', '6144 Manley Plaza', 'asteblesw@about.me', '609-391-5109', '18.02.1985', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Caryl', 'Iskov', '03 Waywood Alley', 'ciskovx@fc2.com', '768-808-5782', '12.04.1988', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lana', 'Fargher', '400 Sherman Place', 'lfarghery@mayoclinic.com', '122-185-6359', '05.08.1985', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Gretta', 'Hardington', '40968 Hallows Junction', 'ghardingtonz@t.co', '201-650-7110', '08.06.2005', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Kalli', 'Pescott', '280 Carey Alley', 'kpescott10@princeton.edu', '620-866-0331', '17.02.2021', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Patience', 'Hasselby', '7234 Dayton Crossing', 'phasselby11@icq.com', '832-681-5393', '07.06.2013', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Hanny', 'Pettiford', '1660 Doe Crossing Terrace', 'hpettiford12@statcounter.com', '286-906-6361', '23.09.1990', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Lorianna', 'Jennins', '9371 Cardinal Parkway', 'ljennins13@seesaa.net', '956-639-4158', '26.07.2007', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Asher', 'Shapland', '57 Sommers Way', 'ashapland14@linkedin.com', '885-249-6407', '03.01.1993', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Dela', 'Varnals', '8 Judy Alley', 'dvarnals15@google.ru', '264-299-6301', '19.04.2007', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Philipa', 'Foale', '68082 Comanche Parkway', 'pfoale16@cnbc.com', '732-815-1989', '17.12.2004', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Loutitia', 'MacGilfoyle', '30 Melrose Trail', 'lmacgilfoyle17@msn.com', '689-131-9424', '11.07.2014', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Talbot', 'Whoston', '43 Kingsford Road', 'twhoston18@sitemeter.com', '202-824-9063', '19.01.2013', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Scot', 'Saddleton', '38167 Towne Junction', 'ssaddleton19@themeforest.net', '698-318-2525', '06.12.2008', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Ezequiel', 'MacKenney', '246 Autumn Leaf Drive', 'emackenney1a@deliciousdays.com', '126-227-7059', '20.04.1989', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Venus', 'Lobb', '44 Kingsford Trail', 'vlobb1b@ezinearticles.com', '585-427-8240', '17.02.1984', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Arni', 'Kanter', '775 Riverside Hill', 'akanter1c@webs.com', '174-369-4488', '12.09.2012', 0, 2, 3);
        insert into personas (nombre, apellido, direccion, email, telefono, fecha_nac, legajo, tipo_persona, id_plan) values ('Malia', 'Fuller', '0526 Texas Circle', 'mfuller1d@gravatar.com', '422-964-8339', '25.10.2005', 0, 2, 3);
    --
--USUARIOS CON LOS DATOS DE LAS PERSONAS
    USE [Academia]
    GO
        insert into usuarios (nombre_usuario, clave, habilitado, nombre, apellido, email, id_persona )
        select concat(p.nombre, p.apellido), 12345678, 1, p.nombre, p.apellido, p.email, p.id_persona
        from personas p
    GO
--



--MATERIAS
    --MATERIAS PLAN #1        
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Suite Française', 3, 64, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Wedding March, The', 4, 56, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Frankenstein', 3, 32, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Weekend', 5, 56, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Thick-Walled Room, The (Kabe atsuki heya)', 6, 43, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('That Lady in Ermine', 4, 54, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Boot Camp', 3, 62, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Breathing Room', 5, 44, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('My Best Friend''s Girl', 3, 33, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Hunky Dory', 3, 37, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Quiet as a Mouse (Muxmäuschenstill)', 4, 35, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Lifeguard, The', 5, 41, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('American Revolutionary', 6, 56, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Anthropophagus ', 5, 44, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Meteor', 5, 63, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('What Price Hollywood?', 3, 43, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Everybody''s All-American', 4, 60, 1);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Boys Don''t Cry', 4, 36, 1);
    --
    --MATERIAS PLAN #2
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Blindness', 5, 38, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('A Pigeon Sat on a Branch Reflecting on Existence', 6, 30, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Dogwalker, The', 3, 62, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Union Square', 5, 41, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Brothers Grimm, The', 4, 34, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Tron: Legacy', 4, 47, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Samurai (Samourais)', 3, 37, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Story of Yonosuke, A (Yokomichi Yonosuke)', 3, 44, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Cannibal Women in the Avocado Jungle of Death', 4, 46, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('What''s Love Got to Do with It?', 3, 36, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Abbott and Costello in Hollywood', 4, 51, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Postman, The', 6, 42, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Blondie on a Budget', 5, 51, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('9 Souls (Nain souruzu)', 3, 38, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Remote Control', 6, 70, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Through and Through (Na wylot)', 3, 41, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Little Birds', 4, 37, 2);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Number Seventeen (a.k.a. Number 17)', 3, 49, 2);
    --
    --MATERIAS PLAN #3
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('My Favorite Season', 4, 55, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Souls for Sale', 4, 65, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Deadly Surveillance', 6, 69, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Charter Trip, The (a.k.a. Package Tour, The) (Sällskapsresan)', 4, 59, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Legendary', 3, 46, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Raincoat', 3, 35, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Manhattan Baby', 3, 49, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Naked Souls', 3, 52, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Everybody''s Woman (La signora di tutti)', 5, 53, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Axed', 3, 48, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Zoom', 3, 59, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('The Wonders', 4, 33, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Vinyan', 5, 65, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Supercross', 5, 49, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('Four Eyes and Six-Guns', 6, 48, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('End of Summer', 4, 42, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('976-EVIL', 3, 66, 3);
        insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) values ('My Science Project', 6, 48, 3);        
    --
--COMISIONES
    --COMISIONES PLAN #1
        --AÑO 1
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('101', 1, 1);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('102', 1, 1);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('103', 1, 1);
        --AÑO 2
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('201', 2, 1);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('202', 2, 1);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('203', 2, 1);
        --AÑO 3
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('301', 3, 1);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('301', 3, 1);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('303', 3, 1);
    --
    --COMISIONES PLAN #2
        --AÑO 1
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('101', 1, 2);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('102', 1, 2);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('103', 1, 2);
        --AÑO 2
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('201', 2, 2);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('202', 2, 2);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('203', 2, 2);
        --AÑO 3
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('301', 3, 2);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('301', 3, 2);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('303', 3, 2);
    --
    --COMISIONES PLAN #3
        --AÑO 1
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('101', 1, 3);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('102', 1, 3);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('103', 1, 3);
        --AÑO 2
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('201', 2, 3);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('202', 2, 3);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('203', 2, 3);
        --AÑO 3
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('301', 3, 3);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('301', 3, 3);
        INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) VALUES('303', 3, 3);
    --
--
--CURSOS
    --Crea un curso en cada comision para cada materia
        --plan 1
        insert into cursos (id_materia, id_comision, anio_calendario, cupo) 
            select m.id_materia, c.id_comision, 2022, 10
            from materias m 
            inner join comisiones c on c.id_plan = m.id_plan
            where c.anio_especialidad = 1 and m.id_materia <7;   

        insert into cursos (id_materia, id_comision, anio_calendario, cupo) 
            select m.id_materia, c.id_comision, 2022, 10
            from materias m 
            inner join comisiones c on c.id_plan = m.id_plan
            where c.anio_especialidad = 2 and m.id_materia > 6 and m.id_materia < 13   ;  
        
        insert into cursos (id_materia, id_comision, anio_calendario, cupo) 
            select m.id_materia, c.id_comision, 2022, 10
            from materias m 
            inner join comisiones c on c.id_plan = m.id_plan
            where c.anio_especialidad = 3 and m.id_materia > 12 and m.id_materia < 19; 
    	--plan 2
        insert into cursos (id_materia, id_comision, anio_calendario, cupo) 
            select m.id_materia, c.id_comision, 2022, 10
            from materias m 
            inner join comisiones c on c.id_plan = m.id_plan
            where c.anio_especialidad = 1 and m.id_materia > 18 and m.id_materia < 25;   

        insert into cursos (id_materia, id_comision, anio_calendario, cupo) 
            select m.id_materia, c.id_comision, 2022, 10
            from materias m 
            inner join comisiones c on c.id_plan = m.id_plan
            where c.anio_especialidad = 2 and m.id_materia > 24 and m.id_materia < 31   ;  
        
        insert into cursos (id_materia, id_comision, anio_calendario, cupo) 
            select m.id_materia, c.id_comision, 2022, 10
            from materias m 
            inner join comisiones c on c.id_plan = m.id_plan
            where c.anio_especialidad = 3 and m.id_materia > 30 and m.id_materia < 37  ; 
        --plan 3
        insert into cursos (id_materia, id_comision, anio_calendario, cupo) 
            select m.id_materia, c.id_comision, 2022, 10
            from materias m 
            inner join comisiones c on c.id_plan = m.id_plan
            where c.anio_especialidad = 1 and m.id_materia > 36 and m.id_materia < 43;   

        insert into cursos (id_materia, id_comision, anio_calendario, cupo) 
            select m.id_materia, c.id_comision, 2022, 10
            from materias m 
            inner join comisiones c on c.id_plan = m.id_plan
            where c.anio_especialidad = 2 and m.id_materia > 42 and m.id_materia < 49   ;  
        
        insert into cursos (id_materia, id_comision, anio_calendario, cupo) 
            select m.id_materia, c.id_comision, 2022, 10
            from materias m 
            inner join comisiones c on c.id_plan = m.id_plan
            where c.anio_especialidad = 3 and m.id_materia > 48 ;
    --
--
--
