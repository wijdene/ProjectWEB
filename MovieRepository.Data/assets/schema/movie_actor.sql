CREATE TABLE IF NOT EXISTS movie_actor (
  movie_id INTEGER NOT NULL,
  actor_id INTEGER NOT NULL,
  PRIMARY KEY (movie_id, actor_id),
  FOREIGN KEY (movie_id) REFERENCES movie(id) ON DELETE CASCADE,
  FOREIGN KEY (actor_id) REFERENCES actor(id) ON DELETE CASCADE
);