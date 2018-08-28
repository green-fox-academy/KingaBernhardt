package com.kindergarten.demo.Services;

import com.kindergarten.demo.Models.Parent;
import com.kindergarten.demo.Repositories.ParentRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class ParentServiceImp implements ParentService {

  private ParentRepository parentRepository;

  @Autowired
  public ParentServiceImp(ParentRepository parentRepository) {
    this.parentRepository = parentRepository;
  }

  @Override
  public Parent getParentById(Long id) {
    return parentRepository.findById(id).get();
  }

  @Override
  public void addParent(Parent parent) {
    parentRepository.save(parent);
  }

  @Override
  public void deleteParentById(Long id) {
    parentRepository.deleteById(id);
  }

  @Override
  public Iterable<Parent> getAllParent() {
    return parentRepository.findAll();
  }
}
