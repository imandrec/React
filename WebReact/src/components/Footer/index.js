import React from 'react';
import {animateScroll as scroll} from 'react-scroll';
import { FaFacebook, FaLinkedin} from 'react-icons/fa'
import { FooterContainer, FooterWrap, FooterLinksContainer, FooterLinksWrapper, FooterLinkItems, FooterLinkTitle, FooterLink, SocialMedia, SocialMediaWrap, SocialLogo, WebsiteRights, SocialIcons, SocialIconLink } from './FooterElements';

const Footer = () => {
    const toggleHome = () => {
        scroll.scrollToTop();
    };
    return (
        <FooterContainer>
            <FooterWrap>
                <FooterLinksContainer>
                    <FooterLinksWrapper>
                        <FooterLinkItems>
                            <FooterLinkTitle> About Us </FooterLinkTitle>
                                <FooterLink to='/signin'> How it works </FooterLink>
                                <FooterLink to='/signin'> Testimonials </FooterLink>
                                <FooterLink to='/signin'> Contact Us </FooterLink>
                                <FooterLink to='/signin'> Terms of service </FooterLink>                            
                        </FooterLinkItems>
                        <FooterLinkItems>
                            <FooterLinkTitle> Recent Posts </FooterLinkTitle>
                                <FooterLink to='/signin'> One </FooterLink>
                                <FooterLink to='/signin'> Two </FooterLink>
                                <FooterLink to='/signin'> Three </FooterLink>                          
                        </FooterLinkItems>
                        <FooterLinkItems>
                            <FooterLinkTitle> About Us </FooterLinkTitle>
                                <FooterLink to='/signin'> How it works </FooterLink>
                                <FooterLink to='/signin'> Careers </FooterLink>
                                <FooterLink to='/signin'> Contact Us </FooterLink>
                                <FooterLink to='/signin'> Terms of service </FooterLink>                            
                        </FooterLinkItems>
                        <FooterLinkItems>
                            <FooterLinkTitle> Social Media </FooterLinkTitle>
                                <FooterLink to='/signin'> Facebook </FooterLink>
                                <FooterLink to='/signin'> LinkedIn </FooterLink>                          
                        </FooterLinkItems>
                    </FooterLinksWrapper>
                </FooterLinksContainer>
                <SocialMedia>
                    <SocialMediaWrap>
                        <SocialLogo to='/' onClick={toggleHome}>dolla</SocialLogo>
                        <WebsiteRights>Consultant © {new Date().getFullYear()} All rights reserved.</WebsiteRights>
                        <SocialIcons>
                            <SocialIconLink href='/' target='_blank' aria-label='Facebook'>< FaFacebook /></SocialIconLink>
                            <SocialIconLink href='/' target='_blank' aria-label='Youtube'>< FaLinkedin /></SocialIconLink>
                        </SocialIcons>
                    </SocialMediaWrap>
                </SocialMedia>
            </FooterWrap>
        </FooterContainer>
    );
};

export default Footer;
