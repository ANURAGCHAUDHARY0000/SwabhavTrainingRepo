SELECT COUNT(*) FROM EMP;
SELECT COUNT(*) FROM DEPT;
SELECT COUNT(*) FROM LOCATIONS;
SELECT COUNT(*) FROM REGIONS;
SELECT COUNT(*) FROM COUNTRIES;
SELECT * FROM EMP;

/* 1.) display all employee names in ascending order */

SELECT *
FROM EMP e
ORDER BY e.ENAME ASC;

/* 2) display all empname ,salary , commision of employees in dept 10 */

SELECT e.ENAME,e.SAL,e.COMM 
FROM EMP e  
where e.DEPTNO = 10


/* 3)dipaly all employees in deptno  20 and 30  */

SELECT e.ENAME
FROM EMP e
WHERE e.DEPTNO = 20 OR e.DEPTNO = 30


/* 4)display all employees who are managers */

SELECT *
 FROM EMP e
 WHERE (e.JOB  ='MANAGER');

 /*5) display all employees whose salary between 2K to 5k  */
SELECT * 
FROM EMP e
WHERE e.SAL BETWEEN (SELECT 2000) AND 5000;
                                         

/*6) diplay all emplyees whose commision is null */

SELECT * 
FROM EMP e
WHERE e.COMM IS NULL; 

/* 8) display employees avg,max,min,sum of salaries -- descriptive stats */

SELECT SUM(e.SAL), AVG(e.SAL), MAX(e.SAL), MIN(e.SAL)
FROM EMP e

/* 9) display hiredate,currentDate,tenure of the employees */

SELECT e.ENAME, GETDATE(), e.HIREDATE, DATEDIFF(YEAR,  e.HIREDATE , GETDATE())
FROM EMP e;

/* 10) display all employees whose name start with 'S' */
SELECT *
FROM EMP 
WHERE ENAME LIKE 'S%';

/*11)display unique deptno from emp table */
SELECT DISTINCT DEPTNO
FROM EMP;

/* 12)display job in lower case */
SELECT LOWER(JOB) 
FROM EMP ;

/* 13)select top 3 salary earning employees */
SELECT *
FROM EMP
WHERE 
(
  SAL IN 
  (
    SELECT TOP (2) SAL
    FROM EMP as EMP1
    GROUP BY SAL
    ORDER BY SAL DESC
  )
)

/* 14)slect all ClERKS and Managers in dept 10 */

SELECT e.JOB
FROM EMP e
WHERE e. DEPTNO = 10 and e.JOB = 'CLERK' OR e.JOB = 'MANAGER' ;

/*15)Display all clerks in ascending order of deptno */

SELECT e.JOB = 'CLERK'
FROM EMP e
ORDER BY e.DEPTNO ASC

--16>Display the deptwise employee count ?


SELECT JOB, COUNT(JOB) FROM EMP GROUP BY JOB  

--  > fequency count of department column

SELECT  DEPTNO , COUNT(DEPTNO) FROM EMP GROUP BY DEPTNO 

-- 19)Display deptwise  employees greater than  3

SELECT JOB ,COUNT(JOB)
FROM EMP
GROUP BY JOB
HAVING COUNT(JOB)>3

-- 21) Display All employees in the same dept of 'SCOTT'
SELECT * FROM EMP
WHERE DEPTNO = (
SELECT DEPTNO FROM EMP WHERE ENAME = 'SCOTT'
)

--22) Employees having same designation of SMITH
SELECT * FROM EMP
WHERE JOB = (
SELECT JOB FROM EMP WHERE ENAME = 'SMITH'
)

--23) Employee who are reproting under KING

SELECT * FROM EMP
    WHERE MGR=(SELECT EMPNO FROM EMP WHERE ENAME='KING')

--24) Employees who have same salary of BLAKE
SELECT * FROM EMP
WHERE SAL = (
SELECT SAL FROM EMP WHERE ENAME = 'BLAKE'
)

--25)Display Employee name,deptname and location

SELECT EMP.ENAME,DEPT.DNAME
FROM EMP
INNER JOIN DEPT ON EMP.DEPTNO = DEPT.DEPTNO;

--26) display all deptnames and corresponing employees if any
 SELECT DEPT.DNAME , EMP.ENAME 
 FROM DEPT LEFT JOIN EMP 
 ON DEPT.DEPTNO = EMP.DEPTNO;

 --27)dipslay all deptnames where there are no employees


 SELECT DEPT.DNAME 
 FROM DEPT LEFT JOIN EMP
 ON DEPT.DEPTNO = EMP.DEPTNO
 WHERE EMP.DEPTNO IS NULL  

--28) display deptname wise  employee count greater than 3 , display in descending order of deptname

SELECT DNAME AS 'Department Name', 
COUNT(*) AS 'No of Employees' 
FROM DEPT 
INNER JOIN EMP 
ON EMP.DEPTNO = DEPT.DEPTNO
GROUP BY DNAME
HAVING COUNT(*)>3
ORDER BY DNAME DESC 

--29) Display all the empname and their manager names

 SELECT A.ENAME AS MANAGER , B.ENAME AS EMPLOYEE   
 FROM EMP A,EMP B
 WHERE A.EMPNO = B.MGR 


-- 30)Display empname,deptname and manager name as bossname , order by boss name

SELECT A.ENAME  AS EMPLOYEE,DEPT.DNAME AS DEPARTMENT ,B.ENAME AS BOSS  
FROM EMP A , EMP B  LEFT JOIN DEPT
ON B.DEPTNO = DEPT.DEPTNO
WHERE B.EMPNO = A.MGR 
ORDER BY B.ENAME

-- 31)Modify query 30 to display output which contains KING and Operations as screenshot above


-- 32)Display location name, country name,city name, region name ,ORDER by region name
  
SELECT REGIONS.region_name , COUNTRIES.COUNTRY_NAME , LOCATIONS.CITY , LOCATIONS.STREET_ADDRESS
FROM REGIONS LEFT JOIN COUNTRIES
ON REGIONS.region_id = COUNTRIES.REGION_ID 
LEFT JOIN LOCATIONS 
ON COUNTRIES.COUNTRY_ID = LOCATIONS.COUNTRY_ID
ORDER BY REGIONS.region_name

-- 33) Display Country where there are no locations availbale in location table
SELECT COUNTRIES.COUNTRY_ID , COUNTRIES.COUNTRY_NAME
FROM COUNTRIES LEFT JOIN LOCATIONS
ON COUNTRIES.COUNTRY_ID = LOCATIONS.COUNTRY_ID
WHERE LOCATIONS.COUNTRY_ID IS NULL 

-- 34) Display the regions where there are no countries available in country table

SELECT REGIONS.region_id , COUNTRIES.COUNTRY_NAME
FROM COUNTRIES LEFT JOIN REGIONS
ON COUNTRIES.COUNTRY_ID = REGIONS.region_id
WHERE COUNTRIES.COUNTRY_ID IS NULL 



