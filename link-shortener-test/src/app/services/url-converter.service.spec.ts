import { TestBed } from '@angular/core/testing';

import { UrlConverterService } from './url-converter.service';

describe('UrlConverterService', () => {
  let service: UrlConverterService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UrlConverterService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
