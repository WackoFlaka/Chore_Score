CREATE TABLE IF NOT EXISTS accounts (
    id VARCHAR(255) NOT NULL primary key COMMENT 'primary key', createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created', updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update', name varchar(255) COMMENT 'User Name', email varchar(255) COMMENT 'User Email', picture varchar(255) COMMENT 'User Picture'
) default charset utf8mb4 COMMENT '';

CREATE TABLE chores (
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT, name VARCHAR(50) NOT NULL, createdAt DATETIME DEFAULT CURRENT_TIMESTAMP, description VARCHAR(500)
);

INSERT INTO
    chores (name, description),
VALUES (
        "Finish Checkpoint", "I need to finish this checkpoint or else Ill die!"
    );

INSERT INTO
    chores (name, description),
VALUES (
        "Finish chores around the house", "My mom would actually kill me if I didn't finish my chores in time."
    );

INSERT INTO
    chores (name, description),
VALUES (
        "Get a job", "Gotta make money somehow"
    );

DELETE * FROM chores;

SELECT * FROM chores;

DROP TABLE chores;