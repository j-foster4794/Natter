import { NatterTemplatePage } from './app.po';

describe('Natter App', function() {
  let page: NatterTemplatePage;

  beforeEach(() => {
    page = new NatterTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
