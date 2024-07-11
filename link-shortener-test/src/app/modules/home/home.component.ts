import { Component } from '@angular/core';
import { UrlConverterService } from '../../services/url-converter.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {
  link: string = ''
  shortLink: string = ''

  links: any[] = [];
  constructor(private urlConvertService: UrlConverterService) {}

  async ngOnInit() {
    const getUrls = await this.urlConvertService.getAll();
    const data: any = getUrls;
    this.links = data;
  }

  async convertLink() {
    const url = this.link;
    console.debug(url);
    const getConverted = await this.urlConvertService.convert(url);
    const data = getConverted;
    this.shortLink = '' //get data from api
    location.reload();
  }
}
