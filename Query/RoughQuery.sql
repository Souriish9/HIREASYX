Select * from JOB
Select * from ADMIN

ALTER TABLE JOB
ADD CONSTRAINT FK_USERID
FOREIGN KEY (USERID) REFERENCES ADMIN(USERID);

INSERT INTO JOB VALUES(1,'DevOps Engineer','WalMart','Pune','Full Time','www.walmart.com','support@walmart.com','ITS','need experienced devops enginner');

UPDATE  JOB
SET JOB.APPLY_LINK='www.walmart.com/careers' WHERE JOB.USERID=1

DELETE FROM JOB WHERE USERID=2;