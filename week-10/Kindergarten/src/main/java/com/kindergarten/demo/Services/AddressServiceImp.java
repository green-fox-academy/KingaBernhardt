package com.kindergarten.demo.Services;

import com.kindergarten.demo.Models.Address;
import com.kindergarten.demo.Repositories.AddressRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class AddressServiceImp implements AddressService {
  private AddressRepository addressRepository;

  @Autowired
  public AddressServiceImp(AddressRepository addressRepository) {
    this.addressRepository = addressRepository;
  }

  @Override
  public Iterable<Address> getAddresses() {
    return addressRepository.findAll();
  }

  @Override
  public Address getAddressById(Long id) {
    return addressRepository.findById(id).get();
  }

  @Override
  public void updateAddress(Address address) {
    addressRepository.save(address);
  }

  @Override
  public void deleteAddressById(Long id) {
    addressRepository.deleteById(id);
  }
}
