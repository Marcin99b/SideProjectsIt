export interface IdeaDto {
  id: string
  title: string
  descriptionShort: string
  tags: string[]
}

export const IdeasMock: IdeaDto[] = [
  {
    id: 'travel-app',
    title: 'Travel app',
    descriptionShort: 'Application about traveling written in any tech stack',
    tags: ['any stack', 'frontend', 'backend', 'travel']
  },
  {
    id: 'shop',
    title: 'Shop',
    descriptionShort: 'Shop management system',
    tags: ['any stack', 'frontend', 'backend', 'shop', 'database']
  },
  {
    id: 'image-recognision',
    title: 'Image recognision',
    descriptionShort: 'Image recognision app',
    tags: ['python', 'tensorflow', 'opencv']
  },
  {
    id: 'travel-app123',
    title: 'Travel app123',
    descriptionShort: 'Application about traveling written in any tech stack',
    tags: ['any stack', 'frontend', 'backend', 'travel']
  },
  {
    id: 'shop123',
    title: 'Shop',
    descriptionShort: 'Shop management system123',
    tags: ['any stack', 'frontend', 'backend', 'shop', 'database']
  },
  {
    id: 'image-recognision123',
    title: 'Image recognision123',
    descriptionShort: 'Image recognision app',
    tags: ['python', 'tensorflow', 'opencv']
  }
]
