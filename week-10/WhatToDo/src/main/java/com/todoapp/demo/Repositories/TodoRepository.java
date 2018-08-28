package com.todoapp.demo.Repositories;

import com.todoapp.demo.Models.Todo;
import org.springframework.stereotype.Repository;
import org.springframework.data.repository.CrudRepository;

import java.util.List;

@Repository
public interface TodoRepository extends CrudRepository<Todo, Long> {
  List<Todo> findAll();

  List<Todo> findAllByTitle(String title);
}
