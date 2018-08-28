package com.kindergarten.demo.Services;

import com.kindergarten.demo.Models.Parent;
import org.springframework.stereotype.Service;

@Service
public interface ParentService {

  Parent getParentById(Long id);

  void addParent(Parent parent);

  void deleteParentById(Long id);

  Iterable<Parent> getAllParent();
}
