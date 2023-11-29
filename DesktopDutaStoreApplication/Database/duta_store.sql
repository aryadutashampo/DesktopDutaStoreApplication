CREATE DATABASE duta_store;
USE duta_store;

CREATE TABLE user_access(
user_id		CHAR(2) PRIMARY KEY,
username	VARCHAR(20),
access_code	VARCHAR(16),
access_status	VARCHAR(20)
);
