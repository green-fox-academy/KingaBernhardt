package com.kindergarten.demo.Models;

import lombok.Getter;
import lombok.NoArgsConstructor;
import lombok.Setter;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
@Getter
@Setter
@NoArgsConstructor
public class Group {
  @Id
  @GeneratedValue(strategy = GenerationType.AUTO)
  private Long id;
  private String information;
  private String name;
  private Integer size;
  
  public Group(String information, String name, Integer size){
    this.information = information;
    this.name = name;
    this.size = size;
  }
}
