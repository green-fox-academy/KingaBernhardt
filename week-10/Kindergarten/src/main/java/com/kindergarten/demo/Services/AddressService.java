package com.kindergarten.demo.Services;

import com.kindergarten.demo.Models.Address;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public interface AddressService {
  Iterable<Address> getAddresses();

  Address getAddressById(Long id);

  void updateAddress(Address address);

  void deleteAddressById(Long id);
}
