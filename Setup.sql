-- CREATE TABLE burgers (
--     id INT NOT NULL AUTO_INCREMENT,
--     title VARCHAR(80),
--     description VARCHAR(255),
--     PRIMARY KEY (id)
-- )

-- INSERT INTO burgers (
--     title,
--     description
-- )
-- VALUES(
--     "The Brick",
--     "Made with a brick of sharp cheddar in place of a burger patty"
-- )

-- CREATE TABLE ingredients (
--     id INT NOT NULL AUTO_INCREMENT,
--     title VARCHAR(80),
--     cal int,
--     PRIMARY KEY (id)
-- )

-- INSERT INTO ingredients (
--     title,
--     cal
-- )
-- VALUES(
--     "Bacon",
--     600
-- )

-- CREATE TABLE burgerIngredients (
--     id INT NOT NULL AUTO_INCREMENT,
--     burgerId INT,
--     ingId INT,
--     PRIMARY KEY (id)
-- )

-- INSERT INTO ingredients (
--     burgerId,
--     ingId
-- )
-- VALUES(
--     1,
--     1
-- )

-- SELECT * FROM burgerIngredients